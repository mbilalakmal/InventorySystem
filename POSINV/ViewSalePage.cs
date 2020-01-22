using MaterialSkin;
using MaterialSkin.Controls;
using POSINV.Models;
using System.ComponentModel;
using System.Windows.Forms;

namespace POSINV
{
    public partial class ViewSalePage : MaterialForm
    {
        SaleModel Sale;

        /// <summary>
        /// Receive sale, load cart items from DB and display in DGV
        /// </summary>
        public ViewSalePage(SaleModel sale)
        {
            InitializeComponent();

            //materialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal500, Primary.Teal700, Primary.Teal100, Accent.Teal400, TextShade.WHITE
                );

            Sale = sale;

            DisplaySale();

        }

        private void DisplaySale()
        {
            //Show sale id, date, misc, total. Show cart DGV productName, UnitPrice, Quantity, Amount
            //MessageBox.Show(Sale.SaleTotal.ToString());

            //Get cart items
            BindingList<CartItemModel> cart = new BindingList<CartItemModel>(
                SQLiteDataAccess.ViewSale(1)
            );


        }



    }
}
