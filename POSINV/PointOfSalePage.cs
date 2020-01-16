using MaterialSkin;
using MaterialSkin.Controls;
using POSINV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
                return subtotal.ToString("C");
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

        private void PointOfSalePage_Load(object sender, EventArgs e)
        {

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

        //display selected product's picture if any
        private void setProductPreview()
        {
            resetProductPreview();

            //If no row is selected, return
            if (dataGridViewProduct.CurrentRow == null)
            {
                return;
            }
            //get product of current row
            ProductModel product = (ProductModel)dataGridViewProduct.CurrentRow.DataBoundItem;

            //set current preview
            pictureProductPreview.Image = ProductModel.ByteToImage(product.Picture);

        }

        private void resetProductPreview()
        {
            //dispose of previous preview
            /*
            if (pictureProductPreview.Image != null)
            {
                pictureProductPreview.Image.Dispose();
                pictureProductPreview.Image = null;
            }
            */
            pictureProductPreview.Image?.Dispose();
            pictureProductPreview.Image = null;
        }

        private void dataGridViewProduct_Click(object sender, EventArgs e)
        {
            //set Image of current row in preview picturebox
            setProductPreview();
        }

        private void textSearchProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            //check if a product is selected and quantity is within limit
            /*
            if ( CanAddToCart())
            {
                //create cartItem and add it to cart
                //update total price etc and quanityt

            }
            */
            MessageBox.Show(CanAddToCart().ToString());

            //if item is already in cart, increment quantity
            if( CanAddToCart() == false)
            {
                return;
            }
            AddToCart();
        }

        private bool CanAddToCart()
        {
            //if product selected and q>0 & q<= p.quantity return true

            ProductModel product = (ProductModel)dataGridViewProduct.CurrentRow?.DataBoundItem;

            if (int.TryParse(textQuantity.Text, out int quantity))
            {
                if ( quantity > 0 && quantity <= product?.Quantity)
                {
                    return true;
                }
            }
            return false;

        }

        private void AddToCart()
        {
            ProductModel product = (ProductModel)dataGridViewProduct.CurrentRow.DataBoundItem;

            //check if item already in cart, then update instead of create
            CartItemModel cartItem = cart.FirstOrDefault<CartItemModel>(
                x => x.ProductId == product.ProductId
                );

            if( cartItem != default(CartItemModel))
            {
                //update quantity
                cartItem.Quantity += int.TryParse(textQuantity.Text, out int number) ? number : 1;
            }
            else
            {
                cartItem = new CartItemModel
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    UnitPrice = product.ListPrice,
                    Quantity = int.TryParse(textQuantity.Text, out int number) ? number : 1
                };
                cart.Add(cartItem);
            }

            //update total
            NotifyPropertyChanged("Subtotal");

            //decrement from product


        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            //check if a product is selected, revert quantity and total
            MessageBox.Show(CanRemoveFromCart().ToString());

            if(CanRemoveFromCart() == false)
            {
                return;
            }
            RemoveFromCart();

        }

        private bool CanRemoveFromCart()
        {
            //if product selected remove it from cart

            CartItemModel cartItem = (CartItemModel)dataGridViewCart.CurrentRow?.DataBoundItem;
            return cartItem != null;
        }

        private void RemoveFromCart()
        {
            CartItemModel cartItem = (CartItemModel)dataGridViewCart.CurrentRow.DataBoundItem;
            cart.Remove(cartItem);
            NotifyPropertyChanged("Subtotal");
        }
        
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //Ask For Misc Charges, add to subtotal
            //Create Sale Item, Store in DB
            //Create SaleDetail Items, Store in DB
            //Update stock quantity of products
        }
    }
}
