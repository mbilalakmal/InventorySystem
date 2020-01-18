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

        //private readonly object product;

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

            setProductPreview();
        }
        
        private void dataGridViewProduct_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            /// <summary>
            /// Remove Extra Columns
            /// </summary>
            dataGridViewProduct.Columns["Picture"].Visible = false;
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
            comboBrand.ValueMember = "brandId";
            comboBrand.DisplayMember = "brandName";
            comboBrand.DataSource = brands;
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

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            ResetProductPicture();  //remove previous picture

            //if a picture file is selected, display it
            if (openFilePicture.ShowDialog() == DialogResult.OK)
            {
                pictureProduct.Load(openFilePicture.FileName);
            }
        }
        
        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Validate fields. Save in DB and refresh DGV
            /// </summary>
            
            if ( CanSaveProduct() == true)
            {
                SaveProduct();
            }
            
        }

        private bool CanSaveProduct()
        {
            /// <summary>
            /// Validates all product fields and return true
            /// </summary>

            //ProductName must not be empty
            if ( string.IsNullOrWhiteSpace(textName.Text))
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
            if ( (BrandModel)comboBrand.SelectedItem == default(BrandModel) )
            {
                return false;
            }

            //Category must be valid
            if ( (CategoryModel)comboCategory.SelectedItem == default(CategoryModel))
            {
                return false;
            }

            return true;
        }

        private void SaveProduct()
        {
            //get Image from picturebox
            byte[] picture = null;
            if (pictureProduct.Image != null)
            {
                picture = ProductModel.ImageToByte(
                    pictureProduct.Image, pictureProduct.Image.RawFormat
                );
            }

            //get Brand & Category IDs
            var brand = (BrandModel)comboBrand.SelectedItem;
            var category = (CategoryModel)comboCategory.SelectedItem;

            ProductModel product = new ProductModel
            {
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

            //Add To DB & Refresh DGV
            try
            {
                product.ProductId = SQLiteDataAccess.SaveProduct(product, brand.BrandId, category.CategoryId);
                products.Add(product);
                WireUpProductDataGridView();
                ResetProductInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FAILED TO SAVE!");
            }

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

        private void pictureProduct_Click(object sender, EventArgs e)
        {
            ResetProductPicture();  //remove picture
        }

        private void ResetProductInputs()
        {
            textName.ResetText();
            textCost.ResetText();
            textList.ResetText();
            textQuantity.ResetText();
            textDescription.ResetText();
            //comboBrand.ResetText();
            //comboCategory.ResetText();
            ResetProductPicture();
        }

        private void ResetProductPicture()
        {
            pictureProduct.Image?.Dispose();
            pictureProduct.Image = null;
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
            ///validates product selection then deletes from DB and List
            if ( CanDeleteProduct() == true )
            {
                //Get the relevant product
                ProductModel product = (ProductModel)dataGridViewProduct.CurrentRow.DataBoundItem;
                DeleteProduct(product);
            }
        }

        private bool CanDeleteProduct()
        {
            ///Checks if a valid product is selected
            return dataGridViewProduct.CurrentRow != null;
        }

        private void DeleteProduct(ProductModel product)
        {
            ///Deletes given product from DB & list
            if ( ConfirmDeleteItem(product.ProductName) == true )
            {
                try
                {
                    SQLiteDataAccess.DeleteProduct(product.ProductId);
                    products.Remove(product);
                    WireUpProductDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FAILED TO DELETE!");
                }
            }
        }
        
        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            ///validates brand selection then deletes from DB and List
            if (CanDeleteBrand() == true)
            {
                //Get the relevant brand
                BrandModel brand = (BrandModel)dataGridViewBrand.CurrentRow.DataBoundItem;
                DeleteBrand(brand);
            }
        }

        private bool CanDeleteBrand()
        {
            ///Checks if a valid brand is selected
            return dataGridViewBrand.CurrentRow != null;
        }

        private void DeleteBrand(BrandModel brand)
        {
            ///Deletes given product from DB & list
            if (ConfirmDeleteItem(brand.BrandName) == true)
            {
                try
                {
                    SQLiteDataAccess.DeleteBrand(brand.BrandId);
                    LoadBrandList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FAILED TO DELETE!");
                }
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            ///validates category selection then deletes from DB and List
            if (CanDeleteCategory() == true)
            {
                //Get the relevant category
                CategoryModel category = (CategoryModel)dataGridViewCategory.CurrentRow.DataBoundItem;
                DeleteCategory(category);
            }
        }

        private bool CanDeleteCategory()
        {
            ///Checks if a valid category is selected
            return dataGridViewCategory.CurrentRow != null;
        }

        private void DeleteCategory(CategoryModel category)
        {
            ///Deletes given category from DB & list
            if (ConfirmDeleteItem(category.CategoryName) == true)
            {
                try
                {
                    SQLiteDataAccess.DeleteCategory(category.CategoryId);
                    LoadCategoryList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FAILED TO DELETE!");
                }
            }
        }

        private bool ConfirmDeleteItem(string itemName)
        {
            /// <summary>
            /// Confirms delete action from user via a MessageBox and returns a <see cref="bool"/>
            /// </summary>
            string confirmText = string.Format("Delete {0} Permenantly?", itemName);
            string confirmCaption = "Confirm Delete";

            DialogResult confirmDelete = MessageBox.Show(confirmText, confirmCaption, MessageBoxButtons.YesNo);
            return (confirmDelete == DialogResult.Yes);
        }
        
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            ProductModel product = (ProductModel)dataGridViewProduct.CurrentRow?.DataBoundItem;

            if ( product != default(ProductModel))
            {
                using (var form = new UpdateProductPage(product, brands, categories))
                {
                    var result = form.ShowDialog();
                    
                    WireUpProductDataGridView();    //refresh product DGV
                    LoadBrandList();    //refresh brands
                    LoadCategoryList(); //refresh categories
                }
            }
        }

        private void btnUpdateBrand_Click(object sender, EventArgs e)
        {
            BrandModel brand = (BrandModel)dataGridViewBrand.CurrentRow?.DataBoundItem;

            if ( brand != default(BrandModel))
            {
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
                        
                        WireUpProductDataGridView();    //refresh product DGV
                    }
                }

            }
            
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            CategoryModel category = (CategoryModel)dataGridViewCategory.CurrentRow?.DataBoundItem;

            if (category != default(CategoryModel))
            {
                var updatedProducts = products.Where(
                    product => product.BrandName.Equals(category.CategoryName)
                ).ToList();

                using (var form = new UpdateCategoryPage(category))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        //reload list to include this category
                        LoadCategoryList();

                        //update products in datagridview
                        updatedProducts.ForEach(
                            product => product.CategoryName.Equals(category.CategoryName)
                        );

                        WireUpProductDataGridView();    //refresh product DGV
                    }
                }

            }
            
        }
        
        private void dataGridViewProduct_Click(object sender, EventArgs e)
        {
            //set Image of current row in preview picturebox
            setProductPreview();
        }

        private void setProductPreview()
        {
            resetProductPreview();  //remove previous image

            ProductModel product = (ProductModel)dataGridViewProduct.CurrentRow?.DataBoundItem;
            if ( product != default(ProductModel))  //if a valid row is selected
            {
                pictureProductPreview.Image = ProductModel.ByteToImage(product.Picture);
            }

        }

        private void resetProductPreview()
        {
            pictureProductPreview.Image?.Dispose();
            pictureProductPreview.Image = null;
        }
        
    }
}
