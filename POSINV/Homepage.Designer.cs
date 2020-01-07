namespace POSINV
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.btnPointOfSale = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnInventory = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnReports = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // btnPointOfSale
            // 
            this.btnPointOfSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPointOfSale.AutoSize = true;
            this.btnPointOfSale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPointOfSale.BackColor = System.Drawing.SystemColors.Control;
            this.btnPointOfSale.Depth = 0;
            this.btnPointOfSale.Icon = null;
            this.btnPointOfSale.Location = new System.Drawing.Point(164, 137);
            this.btnPointOfSale.Margin = new System.Windows.Forms.Padding(10);
            this.btnPointOfSale.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPointOfSale.Name = "btnPointOfSale";
            this.btnPointOfSale.Padding = new System.Windows.Forms.Padding(3);
            this.btnPointOfSale.Primary = false;
            this.btnPointOfSale.Size = new System.Drawing.Size(118, 36);
            this.btnPointOfSale.TabIndex = 0;
            this.btnPointOfSale.Text = "Point Of Sale";
            this.btnPointOfSale.UseVisualStyleBackColor = false;
            this.btnPointOfSale.Click += new System.EventHandler(this.btnPointOfSale_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInventory.AutoSize = true;
            this.btnInventory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInventory.BackColor = System.Drawing.SystemColors.Control;
            this.btnInventory.Depth = 0;
            this.btnInventory.Icon = null;
            this.btnInventory.Location = new System.Drawing.Point(48, 137);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(10);
            this.btnInventory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(3);
            this.btnInventory.Primary = false;
            this.btnInventory.Size = new System.Drawing.Size(96, 36);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReports.AutoSize = true;
            this.btnReports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReports.Depth = 0;
            this.btnReports.Icon = null;
            this.btnReports.Location = new System.Drawing.Point(302, 137);
            this.btnReports.Margin = new System.Windows.Forms.Padding(10);
            this.btnReports.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(3);
            this.btnReports.Primary = false;
            this.btnReports.Size = new System.Drawing.Size(125, 36);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Sales Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(480, 270);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnPointOfSale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 270);
            this.MinimumSize = new System.Drawing.Size(480, 270);
            this.Name = "Homepage";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnPointOfSale;
        private MaterialSkin.Controls.MaterialFlatButton btnInventory;
        private MaterialSkin.Controls.MaterialFlatButton btnReports;
    }
}

