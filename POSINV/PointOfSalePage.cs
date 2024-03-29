﻿using MaterialSkin;
using MaterialSkin.Controls;
using POSINV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace POSINV
{
    public partial class PointOfSalePage : MaterialForm, INotifyPropertyChanged
    {
        public BrandModel SelectedBrand { get; set; }
        public CategoryModel SelectedCategory { get; set; }

        BindingList<SaleModel> Sales;

        BindingList<ProductModel> Products;

        List<BrandModel> Brands;

        List<CategoryModel> Categories;

        BindingList<CartItemModel> Cart = new BindingList<CartItemModel>();
        
        private decimal subtotal;   //bind to labelSubtotalAmount
        
        /// <summary>
        /// Public property for subtotal field
        /// </summary>
        public string Subtotal
        {
            get
            {
                subtotal = 0;
                foreach(var item in Cart)
                {
                    subtotal += item.Amount;
                }
                return subtotal.ToString("C", CultureInfo.CreateSpecificCulture("ur-PK"));
            }
        }

        /// <summary>
        /// Event for handling changes in properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        //Notifies consumers of change in property | set null for all properties
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// This Form is for processing new sales, viewing and updating previous sales
        /// </summary>
        public PointOfSalePage()
        {
            InitializeComponent();

            //materialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal500, Primary.Teal700, Primary.Teal100, Accent.Teal400, TextShade.WHITE
                );


            //Load brands
            LoadBrandList();

            //Load categories
            LoadCategoryList();

            //Load products
            LoadProductList();

            //Load cart items
            WireUpCartDataGridView();

            //Bind labelSubtotalAmount to property
            WireUpSubtotalAmount();

            //Load Previous Sales
            LoadSaleList();
            
        }


        private void LoadBrandList()
        {
            Brands = SQLiteDataAccess.LoadBrands();

            //Display brands in combo box
            WireUpBrandComboBox();

        }

        private void LoadCategoryList()
        {
            Categories = SQLiteDataAccess.LoadCategories();

            //Display categories in combo box
            WireUpCategoryComboBox();
        }

        private void WireUpBrandComboBox()
        {
            brandFilterComboBox.DataSource = null;
            brandFilterComboBox.ValueMember = "brandId";
            brandFilterComboBox.DisplayMember = "brandName";
            brandFilterComboBox.DataSource = Brands;
            // Don't select the first item by default
            brandFilterComboBox.SelectedIndex = -1;
        }

        private void WireUpCategoryComboBox()
        {
            categoryFilterComboBox.DataSource = null;
            categoryFilterComboBox.ValueMember = "categoryId";
            categoryFilterComboBox.DisplayMember = "categoryName";
            categoryFilterComboBox.DataSource = Categories;
            // Don't select the first item by default
            categoryFilterComboBox.SelectedIndex = -1;
        }

        //Bind Subtotal property to label
        private void WireUpSubtotalAmount()
        {
            labelSubTotalAmount.DataBindings.Add(new Binding("Text", this, "Subtotal"));
        }

        //Load sale objects from db
        private void LoadSaleList()
        {
            Sales = new BindingList<SaleModel>(SQLiteDataAccess.LoadSales());
            WireUpSaleDataGridView();
        }

        //Populate sale DGV
        private void WireUpSaleDataGridView()
        {
            dataGridViewSale.DataSource = null;
            dataGridViewSale.DataSource = Sales;
        }

        //Load product objects from db
        private void LoadProductList()
        {
            Products = new BindingList<ProductModel>(SQLiteDataAccess.LoadProducts());

            //Display products in datagridview
            WireUpProductDataGridView();
        }

        //Populate the Products DGV
        private void WireUpProductDataGridView()
        {
            dataGridViewProduct.DataSource = null;
            dataGridViewProduct.DataSource = Products;

            setProductPreview();
        }

        //Remove unnecessary columns from product DGV
        private void dataGridViewProduct_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewProduct.Columns["ProductId"].Visible = false;
            dataGridViewProduct.Columns["Picture"].Visible = false;
            dataGridViewProduct.Columns["UpdatedOn"].Visible = false;

            //Also remove cost price because of customer
            dataGridViewProduct.Columns["CostPrice"].Visible = false;
        }

        //Populate the Cart DGV
        private void WireUpCartDataGridView()
        {
            dataGridViewCart.DataSource = null;
            dataGridViewCart.DataSource = Cart;
        }

        //Remove unnecessary columns from cart DGV
        private void dataGridViewCart_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewCart.Columns["ProductId"].Visible = false;
            dataGridViewCart.Columns["UnitCost"].Visible = false;
        }

        //Display selected product's picture if any
        private void setProductPreview()
        {
            resetProductPreview();

            ProductModel product = (ProductModel)dataGridViewProduct.CurrentRow?.DataBoundItem;

            if ( product != default(ProductModel))
            {
                pictureProductPreview.Image = ProductModel.ByteToImage(product.Picture);
            }
        }

        private void resetProductPreview()
        {
            //Dispose of previous preview
            pictureProductPreview.Image?.Dispose();
            pictureProductPreview.Image = null;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            //Validate product selection and quantity
            if ( CanAddToCart() == true)
            {
                AddToCart();
            }
        }

        private bool CanAddToCart()
        {
            //Check if a product is selected and quantity is valid (0-Product.Quantity]
            ProductModel product = (ProductModel)dataGridViewProduct.CurrentRow?.DataBoundItem;

            return int.TryParse(textQuantity.Text, out int quantity) ?
                (quantity > 0 && quantity <= product?.Quantity) : false;

        }

        private void AddToCart()
        {
            //If item is already in cart, update quantity otherwise add it to cart
            ProductModel product = (ProductModel)dataGridViewProduct.CurrentRow.DataBoundItem;

            //check if item already in cart
            CartItemModel cartItem = Cart.FirstOrDefault<CartItemModel>(
                x => x.ProductId == product.ProductId
                );

            if( cartItem != default(CartItemModel))
            {
                //reset product quantity | add previous item quantity back
                product.Quantity += cartItem.Quantity;

                //Update quantity of existing cartItem
                cartItem.Quantity += int.TryParse(textQuantity.Text, out int number) ? number : 1;
            }
            else
            {
                //create a new cartItem & Add it to cart
                cartItem = new CartItemModel
                {
                    ProductId = product.ProductId,
                    Description = product.Description,
                    UnitCost = product.CostPrice,
                    UnitPrice = product.ListPrice,
                    Quantity = int.TryParse(textQuantity.Text, out int number) ? number : 1
                };
                Cart.Add(cartItem);
            }

            //update Subtotal
            NotifyPropertyChanged("Subtotal");

            //decrement from product
            product.Quantity -= cartItem.Quantity;

            ResetTextQuantity();
        }

        private void ResetTextQuantity()
        {
            textQuantity.Text = 1.ToString();
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            //Validate cart item selection
            if ( CanRemoveFromCart() == true )
            {
                RemoveFromCart();
            }
        }

        private bool CanRemoveFromCart()
        {
            //Checks if a cartItem is selected

            CartItemModel cartItem = (CartItemModel)dataGridViewCart.CurrentRow?.DataBoundItem;
            return cartItem != null;
        }

        private void RemoveFromCart()
        {
            //Remove Item from cart, update Subtotal, and increment product quantity
            CartItemModel cartItem = (CartItemModel)dataGridViewCart.CurrentRow.DataBoundItem;
            Cart.Remove(cartItem);

            NotifyPropertyChanged("Subtotal");

            //Get the relevant product and reset quantity
            ProductModel product = Products.First(
                x => x.ProductId == cartItem.ProductId
            );
            product.Quantity += cartItem.Quantity;

        }
        
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if ( CanCheckOut() == true)
            {

                bool success = CheckOut();     //Store Sale to DB

                if ( success == false)
                {
                    return;
                }

                //PrintReceipt
                PrintReceipt();

                CleanUpSale();  //Reset cart, subtotal, & misc
            }
        }
        
        private void PrintReceipt()
        {

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(CreateReceipt);

            try
            {
                printDocument.Print();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "FAILED TO PRINT");
            }

            /*
            using (var printDialog = new PrintDialog())
            {
                PrintDocument printDocument = new PrintDocument();
                printDialog.Document = printDocument;   //add the document to the dialog box
                printDocument.PrintPage += new PrintPageEventHandler(CreateReceipt);

                printDocument.Print();  //start printing process to default printer
                
                //Ask user for print destination
                var dialogResult = printDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    printDocument.Print();  //start the printing process
                }

            }
            */

        }

        private void CreateReceipt(object sender, PrintPageEventArgs e)
        {
            //This function descirbes the graphics object that is printed as invoice

            //Needs Sale object(ID, SaleDate, MiscPrice, SaleTotal) and
            //cart items(ProductName, UnitPrice, Quantity, Amount)

            SaleModel sale = Sales.Last();
            BindingList<CartItemModel> cart = Cart;

            Graphics graphics = e.Graphics;

            Font font = new Font("Source Code Pro", 8);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 80;

            string title = "KAKA  Home & Hardware";

            graphics.DrawString(
                title,
                new Font("Source Code Pro", 12, FontStyle.Bold),
                new SolidBrush(Color.Black),
                startX,
                startY    
            );

            string contact = "          Phone: (021) 34301917 ";

            graphics.DrawString(
                contact, font, new SolidBrush(Color.Black), startX, startY + 30
            );

            string saleId = "Sale: " + sale.SaleId.ToString();

            graphics.DrawString(
                saleId, font, new SolidBrush(Color.Black), startX, startY + offset  
            );
            offset += 2 * (int)fontHeight;  //Consistent spacing

            string saleDate = sale.SaleDate.ToString(CultureInfo.CreateSpecificCulture("ur-PK"));

            graphics.DrawString(
                saleDate, font, new SolidBrush(Color.Black), startX, startY + offset
            );
            offset += 4 * (int)fontHeight;  //Consistent spacing
            
            string productColumn = "PRODUCT", priceColumn = "PRICE", qtyColumn = "QTY", amountColumn = "AMOUNT";

            graphics.DrawString(productColumn, font, new SolidBrush(Color.Black), startX, startY + offset);
            graphics.DrawString(priceColumn, font, new SolidBrush(Color.Black), startX + 100, startY + offset);
            graphics.DrawString(qtyColumn, font, new SolidBrush(Color.Black), startX + 150, startY + offset);
            graphics.DrawString(amountColumn, font, new SolidBrush(Color.Black), startX + 180, startY + offset);
            
            offset += (int)fontHeight;  //Consistent spacing

            graphics.DrawString(
                "------------------------------------------------------------",
                font, new SolidBrush(Color.Black), startX, startY + offset
            );

            offset += 2 * (int)fontHeight;  //Consistent spacing

            //Cart items here -- FOREACH

            decimal subtotal = 0;

            foreach(var item in Cart)
            {

                string product = item.Description,
                    price = item.UnitPrice.ToString(),
                    qty = item.Quantity.ToString(),
                    amount = item.Amount.ToString();
                

                //check if name is longer than 10 characters
                if ( product.Length > 14)
                {
                    //split string in two
                    string[] sep = { " ", "," };
                    int count = 2;
                    string[] parts = product.Split(sep, count, StringSplitOptions.RemoveEmptyEntries);
                    product = string.Join(Environment.NewLine, parts);

                    graphics.DrawString(product, font, new SolidBrush(Color.Black), startX, startY + offset);
                    graphics.DrawString(price, font, new SolidBrush(Color.Black), startX + 100, startY + offset);
                    graphics.DrawString(qty, font, new SolidBrush(Color.Black), startX + 150, startY + offset);
                    graphics.DrawString(amount, font, new SolidBrush(Color.Black), startX + 180, startY + offset);

                    offset += 3 * (int)fontHeight;

                }
                else
                {
                    graphics.DrawString(product, font, new SolidBrush(Color.Black), startX, startY + offset);
                    graphics.DrawString(price, font, new SolidBrush(Color.Black), startX + 100, startY + offset);
                    graphics.DrawString(qty, font, new SolidBrush(Color.Black), startX + 150, startY + offset);
                    graphics.DrawString(amount, font, new SolidBrush(Color.Black), startX + 180, startY + offset);

                    offset += 2 * (int)fontHeight;
                }
                

                /*

                //print the product name
                graphics.DrawString(product, font, new SolidBrush(Color.Black), startX, startY + offset);

                //check if name is longer than PRODUCT column
                if ( product.Length > 14)
                {
                    //push other columns to next line
                    offset += (int)fontHeight;

                }

                graphics.DrawString(price, font, new SolidBrush(Color.Black), startX + 100, startY + offset);
                graphics.DrawString(qty, font, new SolidBrush(Color.Black), startX + 150, startY + offset);
                graphics.DrawString(amount, font, new SolidBrush(Color.Black), startX + 180, startY + offset);

                offset += 2 * (int)fontHeight;

                */

                subtotal += item.Amount;
            }

            //seperator again
            graphics.DrawString(
                "------------------------------------------------------------",
                font, new SolidBrush(Color.Black), startX, startY + offset
            );

            offset += 4 * (int)fontHeight;  //Consistent spacing
            
            string subtotalRow = "Subtotal",
                miscRow = sale.MiscPrice > 0 ? "Misc. Charges": "Discount",
                totalRow = "Total",
                subValue = subtotal.ToString("C", CultureInfo.CreateSpecificCulture("ur-PK")),
                miscValue = sale.MiscPrice.ToString("C", CultureInfo.CreateSpecificCulture("ur-PK")),
                totalValue = sale.SaleTotal.ToString("C", CultureInfo.CreateSpecificCulture("ur-PK"));

            graphics.DrawString(subtotalRow, font, new SolidBrush(Color.Black), startX, startY + offset);
            graphics.DrawString(subValue, font, new SolidBrush(Color.Black), startX + 140, startY + offset);
            
            offset += 2 * (int)fontHeight;

            graphics.DrawString(miscRow, font, new SolidBrush(Color.Black), startX, startY + offset);
            graphics.DrawString(miscValue, font, new SolidBrush(Color.Black), startX + 140, startY + offset);

            offset += 2 * (int)fontHeight;

            graphics.DrawString(totalRow, font, new SolidBrush(Color.Black), startX, startY + offset);
            graphics.DrawString(totalValue, font, new SolidBrush(Color.Black), startX + 140, startY + offset);

            offset += 4 * (int)fontHeight;

            //thank you and contact
            string thankYouLine = "** No Return Or Exchange Without Sales Receipt **";

            graphics.DrawString(
                thankYouLine, new Font("Source Code Pro", 7, FontStyle.Italic),
                new SolidBrush(Color.Black), startX, startY + offset
            );

        }

        private void CleanUpSale()
        {
            Cart.Clear();                       //clear cart items
            textMisc.Text = 0.ToString();       //Reset Misc
            NotifyPropertyChanged("Subtotal");  //Reset subtotal
        }

        private bool CanCheckOut()
        {
            //Validate Misc Charges and that cart is not empty
            
            if ( decimal.TryParse(textMisc.Text, out decimal misc))
            {
                if ( misc > 10000)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            return Cart.Count != 0;
        }

        private bool CheckOut()
        {
            bool success = false;

            //Get Misc Charges
            decimal misc = decimal.Parse(textMisc.Text);

            //Create sale object
            SaleModel sale = new SaleModel
            {
                SaleDate = DateTime.Now,
                MiscPrice = misc,
                SaleTotal = subtotal + misc
            };

            //Add to DB, if successful add to BindingList
            try
            {
                sale.SaleId = SQLiteDataAccess.SaveSale(sale, Cart);
                Sales.Add(sale);
                success = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FAILED TO SAVE!");
            }

            return success;

        }

        private void dataGridViewProduct_CurrentCellChanged(object sender, EventArgs e)
        {
            setProductPreview();    //change preview Image to current Product's
        }

        private void btnDeleteSale_Click(object sender, EventArgs e)
        {
            //Check if sale can be deleted
            if ( CanDeleteSale() == true)
            {
                DeleteSale();
            }
        }

        private bool CanDeleteSale()
        {
            return dataGridViewSale.CurrentRow != null;
        }

        private void DeleteSale()
        {
            //Get relevant sale object
            SaleModel sale = (SaleModel)dataGridViewSale.CurrentRow.DataBoundItem;

            //Confirm from user
            if (ConfirmDeleteItem(sale.SaleId.ToString()) == true)
            {
                try
                {
                    SQLiteDataAccess.DeleteSale(sale.SaleId);
                    Sales.Remove(sale);

                    //Must reload the product DGV to get new quantities
                    LoadProductList();

                    //Also reload empty cart
                    CleanUpSale();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FAILED TO DELETE!");
                }
            }

        }

        private bool ConfirmDeleteItem(string itemName)
        {
            //Returns True If User Accepts Delete Dialog

            string confirmText = string.Format("Delete {0} Permenantly?", itemName);
            string confirmCaption = "Confirm Delete";

            var confirmDelete = MessageBox.Show(confirmText, confirmCaption, MessageBoxButtons.YesNo);
            return (confirmDelete == DialogResult.Yes);
        }

        private void textSearchProduct_TextChanged(object sender, EventArgs e)
        {
            //Fluid Search
            dataGridViewProduct.DataSource = new BindingList<ProductModel>(
                Products.Where(
                    product =>
                    (
                    product.Description.ToUpper().Contains(textSearchProduct.Text.ToUpper()) ||
                    product.BrandName.ToUpper().Contains(textSearchProduct.Text.ToUpper()) ||
                    product.CategoryName.ToUpper().Contains(textSearchProduct.Text.ToUpper())
                    )
                    &&
                    (SelectedBrand == null || product.BrandName == SelectedBrand.BrandName) &&
                    (SelectedCategory == null || product.CategoryName == SelectedCategory.CategoryName)
                ).ToList()
            );

        }

        private void textSearchSale_TextChanged(object sender, EventArgs e)
        {
            //Fluid Search
            dataGridViewSale.DataSource = new BindingList<SaleModel>(
                Sales.Where(
                    sale => sale.SaleId.ToString().Contains( textSearchSale.Text )
                ).ToList()
            );
        }
        
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            //Reset Search Text
            textSearchProduct.ResetText();

            //Reset SelectedBrand and SelectedCategory
            brandFilterComboBox.SelectedIndex = -1;
            categoryFilterComboBox.SelectedIndex = -1;
            SelectedBrand = null;
            SelectedCategory = null;
            dataGridViewProduct.DataSource = Products;
        }

        private void btnSearchSale_Click(object sender, EventArgs e)
        {
            //Reset Search Text
            textSearchSale.ResetText();
        }

        private void btnViewSale_Click(object sender, EventArgs e)
        {
            //check if a valid sale is selected, open new ViewSalePage form
            //and populate DGV with cart Items

            if ( CanDeleteSale() == true)
            {
                ViewSale();
            }
        }

        private void ViewSale()
        {
            //Get relevant sale object
            SaleModel sale = (SaleModel)dataGridViewSale.CurrentRow.DataBoundItem;

            using (var form = new ViewSalePage(sale))
            {
                var result = form.ShowDialog();
            }

        }

        private void brandFilterComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

            BrandModel selectedBrand = (BrandModel)brandFilterComboBox.SelectedItem;

            if (selectedBrand == default(BrandModel))
            {
                SelectedBrand = null;
                dataGridViewProduct.DataSource = new BindingList<ProductModel>(
                    Products.Where(
                        product =>
                        SelectedCategory == null || product.CategoryName == SelectedCategory.CategoryName
                        ).ToList()
                    );
            }
            else
            {
                SelectedBrand = selectedBrand;
                dataGridViewProduct.DataSource = new BindingList<ProductModel>(
                    Products.Where(
                        product =>
                        SelectedCategory == null ?
                        product.BrandName == selectedBrand.BrandName
                        :
                        product.BrandName == selectedBrand.BrandName &&
                        product.CategoryName == SelectedCategory.CategoryName
                        ).ToList()
                    );
            }
        }

        private void categoryFilterComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CategoryModel selectedCategory = (CategoryModel)categoryFilterComboBox.SelectedItem;

            if (selectedCategory == default(CategoryModel))
            {
                SelectedCategory = null;
                dataGridViewProduct.DataSource = new BindingList<ProductModel>(
                    Products.Where(
                        product =>
                        SelectedBrand == null || product.BrandName == SelectedBrand.BrandName
                        ).ToList()
                    );
            }
            else
            {
                SelectedCategory = selectedCategory;
                dataGridViewProduct.DataSource = new BindingList<ProductModel>(
                    Products.Where(
                        product =>
                        SelectedBrand == null ?
                        product.CategoryName == selectedCategory.CategoryName
                        :
                        product.CategoryName == selectedCategory.CategoryName &&
                        product.BrandName == SelectedBrand.BrandName
                        ).ToList()
                    );
            }
        }

        private void textSearchProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
