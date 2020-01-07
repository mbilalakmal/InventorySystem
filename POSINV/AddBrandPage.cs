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
            //create Brand Object And Store To DB
            BrandModel brand = new BrandModel();

            if ( string.IsNullOrWhiteSpace(textName.Text))
            {
                //problem
                MessageBox.Show("Brand Name can not be empty");
                return;
            }
            else
            {
                brand.BrandName = textName.Text;
            }

            //Add This To DB
            SQLiteDataAccess.SaveBrand(brand);
            this.brandName = brand.BrandName;

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        
    }
}
