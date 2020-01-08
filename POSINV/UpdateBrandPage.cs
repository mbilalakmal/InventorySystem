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
    public partial class UpdateBrandPage : MaterialForm
    {
        public BrandModel brand { get; private set; }

        public UpdateBrandPage(BrandModel brandOld)
        {
            InitializeComponent();

            //materialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal500, Primary.Teal700, Primary.Teal100, Accent.Teal400, TextShade.WHITE
            );

            brand = brandOld;

            textName.Text = brand.BrandName;

        }

        private void btnUpdateBrand_Click(object sender, EventArgs e)
        {
            //check if name is ok then update
            brand.BrandName = textName.Text.Trim();

            if ( brand.BrandName.Length == 0)
            {   //problem
                MessageBox.Show("Brand Name can not be empty");
                return;
            }
            //update in db, combobox and datagrid
            SQLiteDataAccess.UpdateBrand(brand);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
