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
    public partial class InventoryPage : MaterialForm
    {
        List<BrandModel> brands = new List<BrandModel>();

        List<CategoryModel> categories = new List<CategoryModel>();

        List<ProductModel> products = new List<ProductModel>();
        private readonly object product;

        public InventoryPage()
        {
            InitializeComponent();

            //materialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal500, Primary.Teal700, Primary.Teal100, Accent.Teal400, TextShade.WHITE
            );

            //load brands
            LoadBrandList();

            //load categories
            LoadCategoryList();

            //load products
            LoadProductList();
        }

        private void LoadProductList()
        {
            products = SQLiteDataAccess.LoadProducts();

            //display products in datagridview
            WireUpProductDataGridView();
        }

        private void WireUpProductDataGridView()
        {
            dataGridViewProduct.DataSource = null;
            dataGridViewProduct.DataSource = products;
        }

        private void LoadBrandList()
        {
            brands = SQLiteDataAccess.LoadBrands();

            //display brands in combo box
            WireUpBrandComboBox();

            //display brands in datagridview
            WireUpBrandDataGridView();
        }

        private void WireUpBrandComboBox()
        {
            comboBrand.DataSource = null;
            comboBrand.Refresh();

            comboBrand.ValueMember = "brandId";
            comboBrand.DisplayMember = "brandName";
            comboBrand.DataSource = brands;
            //comboBrand.Refresh();
        }

        private void WireUpBrandDataGridView()
        {
            dataGridViewBrand.DataSource = null;
            dataGridViewBrand.DataSource = brands;
        }

        private void LoadCategoryList()
        {
            categories = SQLiteDataAccess.LoadCategories();

            //display categories in combo box
            WireUpCategoryComboBox();

            //display categories in datagridview
            WireUpCategoryDataGridView();
        }

        private void WireUpCategoryComboBox()
        {
            comboCategory.DataSource = null;
            comboCategory.ValueMember = "categoryId";
            comboCategory.DisplayMember = "categoryName";
            comboCategory.DataSource = categories;
        }

        private void WireUpCategoryDataGridView()
        {
            dataGridViewCategory.DataSource = null;
            dataGridViewCategory.DataSource = categories;
        }

        private void InventoryPage_Load(object sender, EventArgs e)
        {

        }

        private void comboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void labelBrand_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            //dispose of previous image to release memory
            if( pictureProduct.Image != null)
            {
                pictureProduct.Image.Dispose();
                pictureProduct.Image = null;
            }

            //if a picture file is selected, display it
            if (openFilePicture.ShowDialog() == DialogResult.OK)
            {
                pictureProduct.Load(openFilePicture.FileName);
            }

            
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void textName_Click(object sender, EventArgs e)
        {

        }

        

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            //Create ProductModel Object And Save In DB
            ProductModel product = new ProductModel();

            //check Name
            if( string.IsNullOrWhiteSpace(textName.Text))
            {
                //problem
                MessageBox.Show("Product Name can not be empty");
                return;
            }
            //get Name
            product.ProductName = textName.Text.Trim();

            if( decimal.TryParse(textCost.Text, out decimal cost))
            {
                product.CostPrice = cost;
            }
            else
            {
                //problem
                MessageBox.Show("Cost Price must be a valid decimal value");
                return;
            }

            if( decimal.TryParse(textList.Text, out decimal list))
            {
                product.ListPrice = list;
            }
            else
            {
                //problem
                MessageBox.Show("List Price must be a valid decimal value");
                return;
            }

            if( uint.TryParse(textQuantity.Text, out uint quantity))
            {
                product.Quantity = (int) quantity;
            }
            else
            {
                //problem
                MessageBox.Show("Quantity must be a natural number");
                return;
            }

            product.Description = textDescription.Text.Trim();

            BrandModel brand = (BrandModel) comboBrand.SelectedItem;
            CategoryModel category = (CategoryModel) comboCategory.SelectedItem;

            int brandId = 0;
            if( brand != null )
            {
                brandId = brand.BrandId;
            }
            else
            {
                //problem
                MessageBox.Show("Please select a valid Brand");
                return;
            }

            int categoryId = 0;
            if( category != null)
            {
                categoryId = category.CategoryId;
            }
            else
            {
                //problem
                MessageBox.Show("Please select a valid Category");
                return;
            }

            //get picture from picture box
            if( pictureProduct.Image != null)
            {
                //convert image to byte[] and store in productModel
                byte[] picture = ProductModel.ImageToByte(
                    pictureProduct.Image, pictureProduct.Image.RawFormat
                    );
                product.Picture = picture;
            }

            //Add This To DB
            SQLiteDataAccess.SaveProduct(product, brandId, categoryId);

            //Show Message "Product Stored"
            MessageBox.Show("Product Added Successfully");

            //Reset Inputs
            resetProductInputs();

            //reload Product Data Grid View     --CHANGE WITH list insertion and rewireing
            LoadProductList();                //--NOT NEEDED
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {

            using (var form = new AddBrandPage())
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    //reload list to include this brand
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
                    //reload list to include this category
                    LoadCategoryList();
                    comboCategory.Text = form.categoryName;
                }
            }
        }

        private void pictureProduct_Click(object sender, EventArgs e)
        {
            //Remove Picture
            if (pictureProduct.Image != null)
            {
                pictureProduct.Image.Dispose();
                pictureProduct.Image = null;
            }
        }

        private void openFilePicture_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void resetProductInputs()
        {
            textName.ResetText();
            textCost.ResetText();
            textList.ResetText();
            textQuantity.ResetText();
            textDescription.ResetText();
            //comboBrand.ResetText();
            //comboCategory.ResetText();

            if (pictureProduct.Image != null)
            {
                pictureProduct.Image.Dispose();
                pictureProduct.Image = null;
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            //search for products with (LIKE) in db and update datagridview

            //get text from textSearch and trim leading and trailing whitespace
            string searchString = textSearchProduct.Text.Trim();

            products = SQLiteDataAccess.LoadSearchedProducts(searchString);
            //sth
            WireUpProductDataGridView();

            //reset the text
            textSearchProduct.ResetText();
        }

        private void btnSearchBrand_Click(object sender, EventArgs e)
        {
            string searchString = textSearchBrand.Text.Trim();

            brands = SQLiteDataAccess.LoadSearchedBrands(searchString);

            WireUpBrandDataGridView();

            textSearchBrand.ResetText();
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            string searchString = textSearchCategory.Text.Trim();

            categories = SQLiteDataAccess.LoadSearchedCategories(searchString);

            WireUpCategoryDataGridView();

            textSearchCategory.ResetText();

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            ///Deletes selected row's product and after confirmation
            ///deletes from DB, List, and refreshes DataGrid

            ProductModel product = (ProductModel)dataGridViewProduct.CurrentRow.DataBoundItem;

            if ( confirmDeleteItem( product.ProductName ) == true )
            {
                SQLiteDataAccess.DeleteProduct( product.ProductId );
                
                products.Remove(product);

                WireUpProductDataGridView();
            }
        }
        
        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            ///Deletes selected row's brand and after confirmation
            ///deletes from DB, List, and refreshes DataGrid and ComboBox

            BrandModel brand = (BrandModel)dataGridViewBrand.CurrentRow.DataBoundItem;

            if ( confirmDeleteItem( brand.BrandName ) == true)
            {
                SQLiteDataAccess.DeleteBrand( brand.BrandId );
                
                brands.Remove(brand);

                LoadBrandList();
                
                //remove deleted from products and rewire
                products.RemoveAll(
                    product => product.BrandName == brand.BrandName
                );

                WireUpProductDataGridView();
            }

        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            ///Deletes selected row's category and after confirmation
            ///deletes from DB, List, and refreshes DataGrid and ComboBox

            CategoryModel category = (CategoryModel)dataGridViewCategory.CurrentRow.DataBoundItem;

            if (confirmDeleteItem( category.CategoryName ) == true)
            {
                SQLiteDataAccess.DeleteCategory( category.CategoryId );

                LoadCategoryList();

                //remove deleted from products and rewire
                products.RemoveAll(
                    product => product.CategoryName == category.CategoryName
                );

                WireUpProductDataGridView();
            }

        }

        private bool confirmDeleteItem(string itemName)
        {
            string confirmText = string.Format("Delete {0} Permenantly?", itemName);
            string confirmCaption = "Confirm Delete";

            var confirmDelete = MessageBox.Show(confirmText, confirmCaption, MessageBoxButtons.YesNo);

            return (confirmDelete == DialogResult.Yes);
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            CategoryModel category = (CategoryModel)dataGridViewCategory.CurrentRow.DataBoundItem;

            //select products which have the same category name
            var updatedProducts = products.Where(
                product => product.CategoryName.Equals(category.CategoryName)
                ).ToList();

            using ( var form = new UpdateCategoryPage(category) )
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //reload list to include this category
                    LoadCategoryList();

                    //update products in datagridview
                    updatedProducts.ForEach(
                        product => product.CategoryName = category.CategoryName
                        );

                    //wireup datagrid
                    WireUpProductDataGridView();

                }
            }
        }

        private void btnUpdateBrand_Click(object sender, EventArgs e)
        {
            BrandModel brand = (BrandModel)dataGridViewBrand.CurrentRow.DataBoundItem;

            //select products which have the same brand name
            var updatedProducts = products.Where(
                product => product.BrandName.Equals(brand.BrandName)
                ).ToList();

            using (var form = new UpdateBrandPage(brand))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //reload list to include this brand
                    LoadBrandList();

                    //update products in datagridview
                    updatedProducts.ForEach(
                        product => product.BrandName = brand.BrandName
                        );

                    //wireup datagrid
                    WireUpProductDataGridView();

                }
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            ProductModel product = (ProductModel)dataGridViewProduct.CurrentRow.DataBoundItem;
            /*
            using (var form = new UpdateProductPage(product))
            {
                var result = form.ShowDialog();
            }
            */
            using (var form = new UpdateProductPage(product))
            {
                var result = form.ShowDialog();
            }

        }
    }
}
