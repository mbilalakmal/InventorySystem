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
        public BrandModel Brand { get; private set; }

        public AddBrandPage()
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

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            if ( CanSaveBrand() == true)
            {
                try
                {
                    Brand = new BrandModel
                    { BrandName = textName.Text.Trim() };
                    Brand.BrandId = SQLiteDataAccess.SaveBrand(Brand.BrandName);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FAILED TO SAVE!");
                    DialogResult = DialogResult.Abort;
                }
            }
            else
            {
                DialogResult = DialogResult.Abort;
            }

            Close();
        }

        private bool CanSaveBrand()
        {
            return string.IsNullOrWhiteSpace(textName.Text) != true;
        }

    }
}
