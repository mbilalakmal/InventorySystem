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
        public string categoryName { get; private set; }

        public AddCategoryPage()
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

        private void AddCategoryPage_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            //create Category Object And Store To DB
            CategoryModel category = new CategoryModel();

            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                //problem
                MessageBox.Show("Category Name can not be empty");
                return;
            }
            else
            {
                category.CategoryName = textName.Text;
            }

            //Add This To DB
            SQLiteDataAccess.SaveCategory(category);
            this.categoryName = category.CategoryName;

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    
    }
}
