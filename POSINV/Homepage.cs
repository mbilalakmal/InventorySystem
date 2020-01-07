﻿using MaterialSkin;
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
    public partial class Homepage : MaterialForm
    {
        public Homepage()
        {
            InitializeComponent();

            //materialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme =new ColorScheme(
                Primary.Teal500, Primary.Teal700, Primary.Teal100, Accent.Teal400, TextShade.WHITE
                );
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void btnPointOfSale_Click(object sender, EventArgs e)
        {
            using (var form = new PointOfSalePage())
            {
                form.ShowDialog();
            }
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

            using (var form = new InventoryPage())
            {
                form.ShowDialog();
            }

        }
        

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            using (var form = new ReportsPage())
            {
                form.ShowDialog();
            }
        }
    }
}
