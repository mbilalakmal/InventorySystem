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
    public partial class AddCategoryPage : MaterialForm
    {
        public CategoryModel Category { get; private set; }

        public AddCategoryPage()
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

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (CanSaveCategory() == true)
            {
                try
                {
                    Category = new CategoryModel
                    { CategoryName = textName.Text.Trim() };
                    Category.CategoryId = SQLiteDataAccess.SaveCategory(Category.CategoryName);
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
