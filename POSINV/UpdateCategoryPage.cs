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
    public partial class UpdateCategoryPage : MaterialForm
    {
        public CategoryModel category { get; private set; }

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

            category = categoryOld;

            textName.Text = category.CategoryName;
        }

        private void UpdateCategoryPage_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            //check if name is ok then update
            category.CategoryName = textName.Text.Trim();

            if( category.CategoryName.Length == 0)
            {   //problem
                MessageBox.Show("Category Name can not be empty");
                return;
            }
            //update in db, combobox and datagrid
            SQLiteDataAccess.UpdateCategory(category.CategoryId, category.CategoryName);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
