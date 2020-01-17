using MaterialSkin;
using MaterialSkin.Controls;
using POSINV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace POSINV
{
    public partial class PointOfSalePage : MaterialForm, INotifyPropertyChanged
    {
        //List<ProductModel> products = new List<ProductModel>();
        List<ProductModel> products = new List<ProductModel>();

        //List<CartItemModel> cart = new List<CartItemModel>();
        BindingList<CartItemModel> cart = new BindingList<CartItemModel>();

        //subTotal field bind to labelSubtotalAmount
        private decimal subtotal;
        
        //public property for subtotal field
        public string Subtotal
        {
            get
            {
                subtotal = 0;
                foreach(var item in cart)
                {
                    subtotal += item.Amount;
                }
                return subtotal.ToString("C", CultureInfo.CreateSpecificCulture("ur-PK"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //Notifies consumers of change in property | set null for all properties
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
            
        }

        //bind Subtotal property to label
        private void WireUpSubtotalAmount()
        {
            labelSubTotalAmount.DataBindings.Add(new Binding("Text", this, "Subtotal"));
        }

        //load product objects from db
        private void LoadProductList()
        {
            products = SQLiteDataAccess.LoadProducts();

            //display products in datagridview
            WireUpProductDataGridView();
        }

        //populate the DGV
        private void WireUpProductDataGridView()
        {
            dataGridViewProduct.DataSource = null;
            dataGridViewProduct.DataSource = products;

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
            dataGridViewCart.DataSource = cart;
        }

        //remove unnecessary columns from cart DGV
        private void dataGridViewCart_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewCart.Columns["ProductId"].Visible = false;
        }
        
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            //search for products with (LIKE) in db and update datagridview

            //get text from textSearch and trim leading and trailing whitespace
            string searchString = textSearchProduct.Text.Trim();
            
            products = SQLiteDataAccess.LoadSearchedProducts(searchString);

            WireUpProductDataGridView();

            //reset the text
            textSearchProduct.ResetText();
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
            CartItemModel cartItem = cart.FirstOrDefault<CartItemModel>(
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
                cart.Add(cartItem);
            }

            //update Subtotal
            NotifyPropertyChanged("Subtotal");

            //decrement from product
            product.Quantity -= cartItem.Quantity;
            //refresh productList <--REPLACE WITH BETTER-->
            WireUpProductDataGridView();
            
            ResetTextQuantity();    //textQuantity.Text = 1
        }

        private void ResetTextQuantity()
        {
            textQuantity.Text = (1).ToString();
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
            cart.Remove(cartItem);

            NotifyPropertyChanged("Subtotal");

            //Get the relevant product and reset quantity
            ProductModel product = products.First(
                x => x.ProductId == cartItem.ProductId
                );
            product.Quantity += cartItem.Quantity;
            WireUpProductDataGridView();

        }
        
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //Create Sale Item, Store in DB
            //Create SaleDetail Items, Store in DB
            //Update stock quantity of products

            if ( CanCheckOut() == true)
            {
                //create sale object
                SaleModel sale = new SaleModel { MiscPrice = 0, SaleTotal = subtotal };
                //Save sale & sale details
                SQLiteDataAccess.SaveSale(sale, cart);

                cart.Clear();   //reset cart
                NotifyPropertyChanged("Subtotal"); //reset subtotal
            }
        }

        private bool CanCheckOut()
        {
            ///Validate Misc Charges and that cart is not empty
            return cart.Count != 0;
        }

        private void dataGridViewProduct_CurrentCellChanged(object sender, EventArgs e)
        {
            setProductPreview();    //change preview Image to current Product's
        }
    }
}
