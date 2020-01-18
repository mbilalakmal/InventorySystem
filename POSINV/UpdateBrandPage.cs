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
        public BrandModel Brand { get; private set; }

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

            Brand = brandOld;

            textName.Text = Brand.BrandName;

        }

        private void btnUpdateBrand_Click(object sender, EventArgs e)
        {
            if (CanSaveBrand() == true)
            {
                Brand.BrandName = textName.Text.Trim();
                try
                {
                    SQLiteDataAccess.UpdateBrand(Brand);
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
