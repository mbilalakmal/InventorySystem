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
    public partial class UpdateProductPage : MaterialForm
    {
        public ProductModel product { get; private set; }

        public UpdateProductPage(ProductModel productOld)
        {
            InitializeComponent();

            //materialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal500, Primary.Teal700, Primary.Teal100, Accent.Teal400, TextShade.WHITE
            );

            product = productOld;

            //set fields to old product
            FillInputFields();

        }

        private void FillInputFields()
        {
            textName.Text = product.ProductName;
            textCost.Text = product.CostPrice.ToString();
            textList.Text = product.ListPrice.ToString();
            textQuantity.Text = product.Quantity.ToString();
            textDescription.Text = product.Description;

            comboBrand.Text = product.BrandName;
            comboCategory.Text = product.CategoryName;

            if( product.Picture != null)
            {
                pictureProduct.Image = ProductModel.ByteToImage(product.Picture);
            }

        }
    }
}
