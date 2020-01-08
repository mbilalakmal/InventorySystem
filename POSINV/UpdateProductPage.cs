using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSINV
{
    public partial class UpdateProductPage : MaterialForm
    {
        public ProductModel product { get; private set; }

        public List<BrandModel> brands { get; private set; }

        public List<CategoryModel> categories { get; private set; }

        public UpdateProductPage(ProductModel productOld, List<BrandModel> brands, List<CategoryModel> categories)
        {
            InitializeComponent();

            //materialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal500, Primary.Teal700, Primary.Teal100, Accent.Teal400, TextShade.WHITE
            );

            product = productOld;
            this.brands = brands;
            this.categories = categories;

            //Load comboboxes first
            WireUpBrandComboBox();
            WireUpCategoryComboBox();

            //set fields to old product
            FillInputFields();

        }

        private void WireUpBrandComboBox()
        {
            comboBrand.DataSource = null;
            comboBrand.ValueMember = "brandId";
            comboBrand.DisplayMember = "brandName";
            comboBrand.DataSource = brands;
        }

        private void WireUpCategoryComboBox()
        {
            comboCategory.DataSource = null;
            comboCategory.ValueMember = "categoryId";
            comboCategory.DisplayMember = "categoryName";
            comboCategory.DataSource = categories;
        }

        private void FillInputFields()
        {
            textName.Text = product.ProductName;
            textCost.Text = product.CostPrice.ToString();
            textList.Text = product.ListPrice.ToString();
            textQuantity.Text = product.Quantity.ToString();
            textDescription.Text = product.Description;

            comboBrand.Text = product.BrandName;
            comboCategory.Text = product.CategoryName;

            if( product.Picture != null)
            {
                pictureProduct.Image = ProductModel.ByteToImage(product.Picture);
            }

        }

        private void LoadBrandList()
        {
            brands = SQLiteDataAccess.LoadBrands();
            //display brands in combo box
            WireUpBrandComboBox();
        }

        private void LoadCategoryList()
        {
            categories = SQLiteDataAccess.LoadCategories();
            //display categories in combo box
            WireUpCategoryComboBox();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            using (var form = new AddBrandPage())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //reload list
                    LoadBrandList();

                    comboBrand.Text = form.brandName;

                }
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            using (var form = new AddCategoryPage())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //reload list
                    LoadCategoryList();

                    comboCategory.Text = form.categoryName;
                }
            }
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            //dispose of previous image
            if( pictureProduct.Image != null)
            {
                pictureProduct.Image.Dispose();
                pictureProduct.Image = null;
            }

            //if picture file is selected, display it
            if (openFilePicture.ShowDialog() == DialogResult.OK)
            {
                pictureProduct.Load(openFilePicture.FileName);
            }

        }

        private void pictureProduct_Click(object sender, EventArgs e)
        {
            //Remove Picture
            if ( pictureProduct.Image != null)
            {
                pictureProduct.Image.Dispose();
                pictureProduct.Image = null;
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            //Change ProductModel And Update in DB

            ProductModel productUpdated = new ProductModel();

            //set ID same as old
            productUpdated.ProductId = product.ProductId;

            //Name
            if( string.IsNullOrWhiteSpace(textName.Text))
            {
                MessageBox.Show("Product Name can not be empty");
                return;
            }
            productUpdated.ProductName = textName.Text.Trim();

            //Cost
            if( decimal.TryParse(textCost.Text, out decimal cost))
            {
                productUpdated.CostPrice = cost;
            }
            else
            {
                MessageBox.Show("Cost Price must be a valid decimal value");
                return;
            }

            //List
            if (decimal.TryParse(textList.Text, out decimal list))
            {
                productUpdated.ListPrice = list;
            }
            else
            {
                MessageBox.Show("List Price must be a valid decimal value");
                return;
            }

            //Quantity
            if (uint.TryParse(textQuantity.Text, out uint quantity))
            {
                productUpdated.Quantity = (int)quantity;
            }
            else
            {
                //problem
                MessageBox.Show("Quantity must be a natural number");
                return;
            }

            //Description
            productUpdated.Description = textDescription.Text.Trim();

            BrandModel brand = (BrandModel)comboBrand.SelectedItem;
            CategoryModel category = (CategoryModel)comboCategory.SelectedItem;

            int brandId = 0, categoryId = 0;

            if(brand == null)
            {
                MessageBox.Show("Please select a valid Brand");
                return;
            }
            brandId = brand.BrandId;

            if(category == null)
            {
                MessageBox.Show("Please select a valid Category");
                return;
            }
            categoryId = category.CategoryId;

            //get picture from pictureBox
            if( pictureProduct.Image != null)
            {
                byte[] picture = ProductModel.ImageToByte(
                    pictureProduct.Image, pictureProduct.Image.RawFormat
                    );
                productUpdated.Picture = picture;
            }

            //Add to DB
            SQLiteDataAccess.UpdateProduct(productUpdated, brandId, categoryId);

            product = productUpdated;

            //close form
            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
