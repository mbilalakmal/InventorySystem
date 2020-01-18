using MaterialSkin;
using MaterialSkin.Controls;
using POSINV.Models;
using System;
using System.ComponentModel;
using System.Data;
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

            //bind labelSubtotalAmount to property
            WireUpSubtotalAmount();

            //Load Previous Sales
            LoadSaleList();
            
        }

        //bind Subtotal property to label
        private void WireUpSubtotalAmount()
        {
            labelSubTotalAmount.DataBindings.Add(new Binding("Text", this, "Subtotal"));
        }

        //load sale objects from db
        private void LoadSaleList()
        {
            Sales = new BindingList<SaleModel>(SQLiteDataAccess.LoadSales());
            WireUpSaleDataGridView();
        }

        //populate sale DGV
        private void WireUpSaleDataGridView()
        {
            dataGridViewSale.DataSource = null;
            dataGridViewSale.DataSource = Sales;
        }

        //load product objects from db
        private void LoadProductList()
        {
            //products = SQLiteDataAccess.LoadProducts();

            Products = new BindingList<ProductModel>(SQLiteDataAccess.LoadProducts());

            //display products in datagridview
            WireUpProductDataGridView();
        }

        //populate the DGV
        private void WireUpProductDataGridView()
        {
            dataGridViewProduct.DataSource = null;
            dataGridViewProduct.DataSource = Products;

            setProductPreview();
        }

        //remove unnecessary columns from product DGV
        private void dataGridViewProduct_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewProduct.Columns["ProductId"].Visible = false;
            dataGridViewProduct.Columns["Picture"].Visible = false;
            dataGridViewProduct.Columns["UpdatedOn"].Visible = false;

            //also remove cost price because of customer
            dataGridViewProduct.Columns["CostPrice"].Visible = false;
        }

        //populate the cartItems DGV
        private void WireUpCartDataGridView()
        {
            dataGridViewCart.DataSource = null;
            dataGridViewCart.DataSource = Cart;
        }

        //remove unnecessary columns from cart DGV
        private void dataGridViewCart_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewCart.Columns["ProductId"].Visible = false;
        }

        //display selected product's picture if any
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
            //dispose of previous preview
            pictureProductPreview.Image?.Dispose();
            pictureProductPreview.Image = null;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            ///Validate product selection and quantity
            if ( CanAddToCart() == true)
            {
                AddToCart();
            }
        }

        private bool CanAddToCart()
        {
            ///Check if a product is selected and quantity is valid (0-Product.Quantity]
            ProductModel product = (ProductModel)dataGridViewProduct.CurrentRow?.DataBoundItem;

            return int.TryParse(textQuantity.Text, out int quantity) ?
                (quantity > 0 && quantity <= product?.Quantity) : false;

        }

        private void AddToCart()
        {
            ///If item is already in cart, update quantity otherwise add it to cart
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
            //refresh productList <--REPLACE WITH BETTER-->
            //WireUpProductDataGridView();
            
            ResetTextQuantity();    //textQuantity.Text = 1
        }

        private void ResetTextQuantity()
        {
            textQuantity.Text = 1.ToString();
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            ///Validate CartItem Selection
            if ( CanRemoveFromCart() == true )
            {
                RemoveFromCart();
            }
        }

        private bool CanRemoveFromCart()
        {
            ///Checks if a cartItem is selected

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
            //WireUpProductDataGridView();

        }
        
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //Create Sale Item, Store in DB
            //Create SaleDetail Items, Store in DB
            //Update stock quantity of products

            if ( CanCheckOut() == true)
            {

                CheckOut();
                //Reset Cart, Subtotal, & Misc
                CleanUpSale();
            }
        }

        private void CleanUpSale()
        {
            Cart.Clear();   //clear cart items
            textMisc.Text = 0.ToString();   //reset Misc
            NotifyPropertyChanged("Subtotal");  //reset subtotal
        }

        private bool CanCheckOut()
        {
            ///Validate Misc Charges and that cart is not empty
            
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

        private void CheckOut()
        {
            //get Misc Charges
            decimal misc = decimal.Parse(textMisc.Text);

            //create sale object
            SaleModel sale = new SaleModel
            {
                SaleDate = DateTime.Now,
                MiscPrice = misc,
                SaleTotal = subtotal + misc
            };

            //Add to DB, if success add to BindingList
            try
            {
                sale.SaleId = SQLiteDataAccess.SaveSale(sale, Cart);
                Sales.Add(sale);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FAILED TO SAVE!");
            }
        }

        private void dataGridViewProduct_CurrentCellChanged(object sender, EventArgs e)
        {
            setProductPreview();    //change preview Image to current Product's
        }

        private void btnDeleteSale_Click(object sender, EventArgs e)
        {
            ///check if sale can be deleted
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
            //Delete From DB & DGV
            SaleModel sale = (SaleModel)dataGridViewSale.CurrentRow.DataBoundItem;

            //Confirm
            if (ConfirmDeleteItem(sale.SaleId.ToString()) == true)
            {
                try
                {
                    SQLiteDataAccess.DeleteSale(sale.SaleId);
                    Sales.Remove(sale);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FAILED TO DELETE!");
                }
            }

        }

        private bool ConfirmDeleteItem(string itemName)
        {
            string confirmText = string.Format("Delete {0} Permenantly?", itemName);
            string confirmCaption = "Confirm Delete";

            var confirmDelete = MessageBox.Show(confirmText, confirmCaption, MessageBoxButtons.YesNo);

            return (confirmDelete == DialogResult.Yes);
        }

        private void textSearchProduct_TextChanged(object sender, EventArgs e)
        {
            //fluid search
            dataGridViewProduct.DataSource = new BindingList<ProductModel>(
                Products.Where(
                    product => product.ProductName.ToUpper().Contains( textSearchProduct.Text.ToUpper() )
                ).ToList()
            );

        }

        private void textSearchSale_TextChanged(object sender, EventArgs e)
        {
            //fluid search
            dataGridViewSale.DataSource = new BindingList<SaleModel>(
                Sales.Where(
                    sale => sale.SaleId.ToString().Contains( textSearchSale.Text )
                ).ToList()
            );
        }



        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            textSearchProduct.ResetText();
        }

        private void btnSearchSale_Click(object sender, EventArgs e)
        {
            textSearchSale.ResetText();
        }
    }
}
