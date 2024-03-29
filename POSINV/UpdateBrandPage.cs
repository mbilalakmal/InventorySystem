﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace POSINV
{
    /// <summary>
    /// Material form for UpdateBrandPage
    /// </summary>
    public partial class UpdateBrandPage : MaterialForm
    {
        /// <summary>
        /// Brand object which is received and updated in this form
        /// </summary>
        public BrandModel Brand { get; private set; }

        /// <summary>
        /// This Form is for updating an existing brand. The change is reflected in database and UI
        /// </summary>
        /// <param name="brandOld"></param>
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
