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
    public partial class ReportsPage : MaterialForm
    {
        /// <summary>
        /// This Form is for generating different reports and summaries based on sales
        /// </summary>
        public ReportsPage()
        {
            InitializeComponent();
            
            //materialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal500, Primary.Teal700, Primary.Teal100, Accent.Teal400, TextShade.WHITE
                );


        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //generate the report

            //get total sales (COUNT FROM SALE)
            //get total items sold (UNIQUE PRODUCTID FROM SALEDETAIL)

            //total Earnings (SUM FROM SALE)
            //total Misc Charges (SUM Misc FROM SALE)

        }
    }
}
