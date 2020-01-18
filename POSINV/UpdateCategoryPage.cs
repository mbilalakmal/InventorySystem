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
    /// <summary>
    /// Material form for UpdateCategoryPage
    /// </summary>
    public partial class UpdateCategoryPage : MaterialForm
    {
        /// <summary>
        /// Category object which is received and updated in this form
        /// </summary>
        public CategoryModel Category { get; private set; }

        /// <summary>
        /// This Form is for updating an existing category. The change is reflected in database and UI
        /// </summary>
        /// <param name="categoryOld"></param>
        public UpdateCategoryPage(CategoryModel categoryOld)
        {
            InitializeComponent();

            //materialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal500, Primary.Teal700, Primary.Teal100, Accent.Teal400, TextShade.WHITE
            );

            Category = categoryOld;

            textName.Text = Category.CategoryName;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (CanSaveCategory() == true)
            {
                Category.CategoryName = textName.Text.Trim();
                try
                {
                    SQLiteDataAccess.UpdateCategory(Category);
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

        private bool CanSaveCategory()
        {
            return string.IsNullOrWhiteSpace(textName.Text) != true;
        }

    }
}
