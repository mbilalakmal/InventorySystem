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
    public partial class AddBrandPage : MaterialForm
    {
        public string brandName { get; private set; }

        public AddBrandPage()
        {
            InitializeComponent();

            //materialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal500, Primary.Teal700, Primary.Teal100, Accent.Teal400, TextShade.WHITE
            );
        }

        private void AddBrandPage_Load(object sender, EventArgs e)
        {

        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            brandName = textName.Text.Trim();

            if ( brandName.Length == 0 )
            {   //problem
                MessageBox.Show("Brand Name can not be empty");
                return;
            }

            //Add This To DB
            SQLiteDataAccess.SaveBrand(brandName);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
