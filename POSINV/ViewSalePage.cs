using MaterialSkin;
using MaterialSkin.Controls;
using POSINV.Models;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace POSINV
{
    public partial class ViewSalePage : MaterialForm
    {
        SaleModel Sale;

        BindingList<CartItemModel> Cart;

        /// <summary>
        /// Receive sale, load cart items from DB and display in DGV
        /// </summary>
        public ViewSalePage(SaleModel sale)
        {
            InitializeComponent();

            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            //materialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal500, Primary.Teal700, Primary.Teal100, Accent.Teal400, TextShade.WHITE
                );

            Sale = sale;

            LoadCartList();

            DisplaySale();

        }

        private void LoadCartList()
        {
            Cart = new BindingList<CartItemModel>(SQLiteDataAccess.ViewSale(Sale.SaleId));
            WireUpCartDataGridView();
        }

        private void WireUpCartDataGridView()
        {
            dataGridViewCart.DataSource = null;
            dataGridViewCart.DataSource = Cart;
        }

        private void DisplaySale()
        {
            BindLabels();
        }

        private void BindLabels()
        {
            Binding bindingSaleId = new Binding("Text", Sale, "SaleId");
            labelSaleId.DataBindings.Add(bindingSaleId);

            Binding bindingSaleDate = new Binding("Text", Sale, "SaleDate");
            labelSaleDate.DataBindings.Add(bindingSaleDate);

            Binding bindingMisc = new Binding("Text", Sale, "MiscPrice");
            bindingMisc.Format += new ConvertEventHandler(CurrencyString);
            labelMisc.DataBindings.Add(bindingMisc);
            
            decimal subtotal = 0;
            foreach(var item in Cart)
            { subtotal += item.Amount; }
            labelSubtotal.Text = subtotal.ToString("C", CultureInfo.CreateSpecificCulture("ur-PK"));

            Binding bindingTotal = new Binding("Text", Sale, "SaleTotal");
            bindingTotal.Format += new ConvertEventHandler(CurrencyString);
            labelTotal.DataBindings.Add(bindingTotal);

        }

        private void CurrencyString(object sender, ConvertEventArgs eventArgs)
        {
            eventArgs.Value = ( (decimal) eventArgs.Value).
                ToString("C", CultureInfo.CreateSpecificCulture("ur-PK"));
        }

        private void dataGridViewCart_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //remove columns
            dataGridViewCart.Columns["ProductId"].Visible = false;
            dataGridViewCart.Columns["UnitCost"].Visible = false;
        }

        private void ViewSalePage_Load(object sender, System.EventArgs e)
        {
            //allow resizing columns to auto
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }
    }
}
