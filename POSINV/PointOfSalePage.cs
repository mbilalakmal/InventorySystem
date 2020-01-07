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
    public partial class PointOfSalePage : MaterialForm
    {
        public PointOfSalePage()
        {
            InitializeComponent();

            //materialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.DeepPurple500, Primary.DeepPurple700, Primary.DeepPurple100, Accent.DeepPurple200, TextShade.WHITE
            );
        }

        private void PointOfSalePage_Load(object sender, EventArgs e)
        {

        }
    }
}
