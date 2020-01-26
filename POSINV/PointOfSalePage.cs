using MaterialSkin;
using MaterialSkin.Controls;
using POSINV.Models;
using System;
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
        BindingList<SaleModel> Sales;

        BindingList<ProductModel> Products;
        
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

            //Load products
            LoadProductList();

            //Load cart items
            WireUpCartDataGridView();

            //Bind labelSubtotalAmount to property
            WireUpSubtotalAmount();

            //Load Previous Sales
            LoadSaleList();
            
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
                    ProductName = product.ProductName,
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
                if (true || ConfirmPrintReceipt())
                {
                    PrintReceipt();
                }

                CleanUpSale();  //Reset cart, subtotal, & misc
            }
        }

        private bool ConfirmPrintReceipt()
        {
            //Print receipt of currently processed sale - includes cart items + misc charges

            string confirmText = string.Format("Do You Want To Print Sale: 1");
            string confirmCaption = "Print Receipt";

            DialogResult confirmPrint = MessageBox.Show(confirmText, confirmCaption, MessageBoxButtons.YesNo);
            return (confirmPrint == DialogResult.Yes);
        }

        private void PrintReceipt()
        {
            using (var printDialog = new PrintDialog())
            {
                PrintDocument printDocument = new PrintDocument();
                int itemLength = Cart.Count * 20;
                printDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom 311 x 3XX", 311, 300 + itemLength);
                printDialog.Document = printDocument;   //add the document to the dialog box
                printDocument.PrintPage += new PrintPageEventHandler(CreateReceipt);

                //Ask user for print destination
                var dialogResult = printDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    printDocument.Print();  //start the printing process
                }

            }

        }

        private void CreateReceipt(object sender, PrintPageEventArgs e)
        {
            //This function descirbes the graphics object that is printed as invoice

            //Needs Sale object(ID, SaleDate, MiscPrice, SaleTotal) and
            //cart items(ProductName, UnitPrice, Quantity, Amount)

            SaleModel sale = Sales.Last();
            BindingList<CartItemModel> cart = Cart;

            Graphics graphics = e.Graphics;

            Font font = new Font("Courier New", 7);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            string title = "KAKA HOME & HARDWARE";

            graphics.DrawString(
                title,
                new Font("Courier New", 12, FontStyle.Bold),
                new SolidBrush(Color.Black),
                startX,
                startY    
            );

            string saleId = "Sale: " + sale.SaleId.ToString();

            graphics.DrawString(
                saleId, font, new SolidBrush(Color.Black), startX, startY + offset  
            );
            offset += 2 * (int)fontHeight;  //Consistent spacing

            string saleDate = "Issued At: " + sale.SaleDate;

            graphics.DrawString(
                saleDate, font, new SolidBrush(Color.Black), startX, startY + offset
            );
            offset += 4 * (int)fontHeight;  //Consistent spacing

            string columns = "Product".PadRight(20) + "Price".PadRight(10) + "Qty".PadRight(5) + "Amount".PadRight(10);

            graphics.DrawString(
                columns, font, new SolidBrush(Color.Black), startX, startY + offset
            );

            offset += (int)fontHeight;  //Consistent spacing

            graphics.DrawString(
                "---------------------------------------------",
                font, new SolidBrush(Color.Black), startX, startY + offset
            );

            offset += 2 * (int)fontHeight;  //Consistent spacing

            //Cart items here -- FOREACH

            decimal subtotal = 0;

            foreach(var item in Cart)
            {
                string lineItem = item.ProductName.PadRight(20) +
                    item.UnitPrice.ToString().PadRight(10) +
                    item.Quantity.ToString().PadRight(5) +
                    item.Amount.ToString().PadRight(10);
                graphics.DrawString(
                    lineItem, font, new SolidBrush(Color.Black), startX, startY + offset
                );
                offset += 2 * (int)fontHeight;

                subtotal += item.Amount;
            }

            //seperator again
            graphics.DrawString(
                "---------------------------------------------",
                font, new SolidBrush(Color.Black), startX, startY + offset
            );

            offset += 4 * (int)fontHeight;  //Consistent spacing

            //misc, subtotal, and total
            string subtotalLine = "Subtotal".PadRight(30) + subtotal.ToString("C", CultureInfo.CreateSpecificCulture("ur-PK"));
            string miscLine = "Miscellaneous Charges".PadRight(30) + sale.MiscPrice.ToString("C", CultureInfo.CreateSpecificCulture("ur-PK"));
            string totalLine = "Total".PadRight(30) + sale.SaleTotal.ToString("C", CultureInfo.CreateSpecificCulture("ur-PK"));

            graphics.DrawString(
                subtotalLine, font, new SolidBrush(Color.Black), startX, startY + offset    
            );
            offset += 2 * (int)fontHeight;

            graphics.DrawString(
                miscLine, font, new SolidBrush(Color.Black), startX, startY + offset
            );
            offset += 2 * (int)fontHeight;
            
            graphics.DrawString(
                totalLine, new Font("Courier New", 7, FontStyle.Bold),
                new SolidBrush(Color.Black), startX, startY + offset
            );
            offset += 4 * (int)fontHeight;

            //thank you and contact
            string thankYouLine = "Thank you for your business. Please come again.";

            graphics.DrawString(
                thankYouLine, new Font("Courier New", 7, FontStyle.Italic),
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
                if ( misc < 0 || misc > 10000)
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
                    product => product.ProductName.ToUpper().Contains( textSearchProduct.Text.ToUpper() )
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


    }
}
