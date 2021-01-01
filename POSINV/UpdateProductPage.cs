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
        /// <summary>
        /// Product object which is received and updated in this form
        /// </summary>
        public ProductModel Product { get; private set; }

        /// <summary>
        /// List of all brands used to populate the combobox
        /// </summary>
        public List<BrandModel> Brands { get; private set; }

        /// <summary>
        /// List of all categories used to populate the combobox
        /// </summary>
        public List<CategoryModel> Categories { get; private set; }

        /// <summary>
        /// This Form is for updating an existing product. The change is reflected in database and UI
        /// </summary>
        /// <param name="productOld"></param>
        /// <param name="brands"></param>
        /// <param name="categories"></param>
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

            Product = productOld;
            Brands = brands;
            Categories = categories;

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
            comboBrand.DataSource = Brands;
        }

        private void WireUpCategoryComboBox()
        {
            comboCategory.DataSource = null;
            comboCategory.ValueMember = "categoryId";
            comboCategory.DisplayMember = "categoryName";
            comboCategory.DataSource = Categories;
        }

        private void FillInputFields()
        {
            // Fill input fields with old product
            textSKU.Text = Product.SKU;
            textName.Text = Product.ProductName;
            textCost.Text = Product.CostPrice.ToString();
            textList.Text = Product.ListPrice.ToString();
            textQuantity.Text = Product.Quantity.ToString();
            textDescription.Text = Product.Description;

            comboBrand.Text = Product.BrandName;
            comboCategory.Text = Product.CategoryName;

            if( Product.Picture != null)
            {
                pictureProduct.Image = ProductModel.ByteToImage(Product.Picture);
            }

        }

        private void LoadBrandList()
        {
            Brands = SQLiteDataAccess.LoadBrands();
            //display brands in combo box
            WireUpBrandComboBox();
        }

        private void LoadCategoryList()
        {
            Categories = SQLiteDataAccess.LoadCategories();
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
                    //reload list to include this brand
                    LoadBrandList();
                    comboBrand.Text = form.Brand.BrandName;

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
                    //reload list to include this category
                    LoadCategoryList();
                    comboCategory.Text = form.Category.CategoryName;
                }
            }
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            //dispose of previous image
            pictureProduct.Image?.Dispose();
            pictureProduct.Image = null;

            //if picture file is selected, display it
            if (openFilePicture.ShowDialog() == DialogResult.OK)
            {
                pictureProduct.Load(openFilePicture.FileName);
            }

        }

        private void pictureProduct_Click(object sender, EventArgs e)
        {
            //Remove Picture
            pictureProduct.Image?.Dispose();
            pictureProduct.Image = null;
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if ( CanUpdateProduct() == true)
            {
                UpdateProduct();
            }
        }

        private bool CanUpdateProduct()
        {
            // Validates all product fields and return true

            //SKU must not be empty
            if (string.IsNullOrWhiteSpace(textSKU.Text))
            {
                return false;
            }

            //ProductName must not be empty
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                return false;
            }

            //CostPrice must be a positive real number
            if (decimal.TryParse(textCost.Text, out decimal cost))
            {
                if (cost < 0)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            //ListPrice must be a positive real number
            if (decimal.TryParse(textList.Text, out decimal list))
            {
                if (list < 0)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            //Quantity must be a natural number
            if (uint.TryParse(textQuantity.Text, out _) == false)
            {
                return false;
            }

            //Brand must be valid
            if ((BrandModel)comboBrand.SelectedItem == default(BrandModel))
            {
                return false;
            }

            //Category must be valid
            if ((CategoryModel)comboCategory.SelectedItem == default(CategoryModel))
            {
                return false;
            }

            return true;
        }

        private void UpdateProduct()
        {
            //get Image from picturebox
            byte[] picture = null;
            if (pictureProduct.Image != null)
            {
                picture = ProductModel.ImageToByte(
                    pictureProduct.Image, pictureProduct.Image.RawFormat
                );
            }

            //get Brand & Category ID
            var brand = (BrandModel)comboBrand.SelectedItem;
            var category = (CategoryModel)comboCategory.SelectedItem;

            ProductModel product = new ProductModel
            {
                ProductId = Product.ProductId,
                SKU = textSKU.Text.Trim(),
                ProductName = textName.Text.Trim(),
                CostPrice = decimal.Parse(textCost.Text),
                ListPrice = decimal.Parse(textList.Text),
                Quantity = int.Parse(textQuantity.Text),
                Description = textDescription.Text.Trim(),
                UpdatedOn = DateTime.Now,
                BrandName = brand.BrandName,
                CategoryName = category.CategoryName,
                Picture = picture
            };

            //Update In DB, if successful assign to oldProduct
            try
            {
                SQLiteDataAccess.UpdateProduct(
                    product, brand.BrandId, category.CategoryId);

                //copy each attribute back to Product from product
                CopyBackProperties(product);

                DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FAILED TO UPDATE!");
                DialogResult = DialogResult.Abort;
            }

            Close();

        }

        private void CopyBackProperties(ProductModel product)
        {
            //Copies properties from updated to original
            Product.SKU = product.SKU;
            Product.ProductName = product.ProductName;
            Product.CostPrice = product.CostPrice;
            Product.ListPrice = product.ListPrice;
            Product.Quantity = product.Quantity;
            Product.Description = product.Description;
            Product.UpdatedOn = product.UpdatedOn;
            Product.BrandName = product.BrandName;
            Product.CategoryName = product.CategoryName;
            Product.Picture = product.Picture;
        }

    }
}
