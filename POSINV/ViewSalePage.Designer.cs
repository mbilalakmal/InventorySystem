namespace POSINV
{
    partial class ViewSalePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSalePage));
            this.labelSale = new MaterialSkin.Controls.MaterialLabel();
            this.labelIssued = new MaterialSkin.Controls.MaterialLabel();
            this.labelSaleId = new MaterialSkin.Controls.MaterialLabel();
            this.labelSaleDate = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.labelMisc = new MaterialSkin.Controls.MaterialLabel();
            this.labelSubtotal = new MaterialSkin.Controls.MaterialLabel();
            this.label_misc_charges = new MaterialSkin.Controls.MaterialLabel();
            this.label_subtotal = new MaterialSkin.Controls.MaterialLabel();
            this.labelTotal = new MaterialSkin.Controls.MaterialLabel();
            this.label_total = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSale
            // 
            this.labelSale.AutoSize = true;
            this.labelSale.Depth = 0;
            this.labelSale.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSale.Location = new System.Drawing.Point(12, 77);
            this.labelSale.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSale.Name = "labelSale";
            this.labelSale.Size = new System.Drawing.Size(42, 19);
            this.labelSale.TabIndex = 0;
            this.labelSale.Text = "Sale:";
            // 
            // labelIssued
            // 
            this.labelIssued.AutoSize = true;
            this.labelIssued.Depth = 0;
            this.labelIssued.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelIssued.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelIssued.Location = new System.Drawing.Point(12, 106);
            this.labelIssued.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelIssued.Name = "labelIssued";
            this.labelIssued.Size = new System.Drawing.Size(57, 19);
            this.labelIssued.TabIndex = 1;
            this.labelIssued.Text = "Issued:";
            // 
            // labelSaleId
            // 
            this.labelSaleId.AutoSize = true;
            this.labelSaleId.Depth = 0;
            this.labelSaleId.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelSaleId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSaleId.Location = new System.Drawing.Point(75, 77);
            this.labelSaleId.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSaleId.Name = "labelSaleId";
            this.labelSaleId.Size = new System.Drawing.Size(108, 19);
            this.labelSaleId.TabIndex = 2;
            this.labelSaleId.Text = "materialLabel3";
            // 
            // labelSaleDate
            // 
            this.labelSaleDate.AutoSize = true;
            this.labelSaleDate.Depth = 0;
            this.labelSaleDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelSaleDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSaleDate.Location = new System.Drawing.Point(75, 106);
            this.labelSaleDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSaleDate.Name = "labelSaleDate";
            this.labelSaleDate.Size = new System.Drawing.Size(108, 19);
            this.labelSaleDate.TabIndex = 3;
            this.labelSaleDate.Text = "materialLabel4";
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AllowUserToAddRows = false;
            this.dataGridViewCart.AllowUserToDeleteRows = false;
            this.dataGridViewCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Location = new System.Drawing.Point(12, 146);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.ReadOnly = true;
            this.dataGridViewCart.RowTemplate.Height = 32;
            this.dataGridViewCart.Size = new System.Drawing.Size(336, 260);
            this.dataGridViewCart.TabIndex = 4;
            this.dataGridViewCart.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewCart_DataBindingComplete);
            // 
            // labelMisc
            // 
            this.labelMisc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMisc.AutoSize = true;
            this.labelMisc.Depth = 0;
            this.labelMisc.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelMisc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelMisc.Location = new System.Drawing.Point(240, 466);
            this.labelMisc.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelMisc.Name = "labelMisc";
            this.labelMisc.Size = new System.Drawing.Size(108, 19);
            this.labelMisc.TabIndex = 8;
            this.labelMisc.Text = "materialLabel4";
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Depth = 0;
            this.labelSubtotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSubtotal.Location = new System.Drawing.Point(240, 437);
            this.labelSubtotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(108, 19);
            this.labelSubtotal.TabIndex = 7;
            this.labelSubtotal.Text = "materialLabel3";
            // 
            // label_misc_charges
            // 
            this.label_misc_charges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_misc_charges.AutoSize = true;
            this.label_misc_charges.Depth = 0;
            this.label_misc_charges.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_misc_charges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_misc_charges.Location = new System.Drawing.Point(12, 466);
            this.label_misc_charges.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_misc_charges.Name = "label_misc_charges";
            this.label_misc_charges.Size = new System.Drawing.Size(105, 19);
            this.label_misc_charges.TabIndex = 6;
            this.label_misc_charges.Text = "Misc Charges:";
            // 
            // label_subtotal
            // 
            this.label_subtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_subtotal.AutoSize = true;
            this.label_subtotal.Depth = 0;
            this.label_subtotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_subtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_subtotal.Location = new System.Drawing.Point(12, 437);
            this.label_subtotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_subtotal.Name = "label_subtotal";
            this.label_subtotal.Size = new System.Drawing.Size(69, 19);
            this.label_subtotal.TabIndex = 5;
            this.label_subtotal.Text = "Subtotal:";
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.AutoSize = true;
            this.labelTotal.Depth = 0;
            this.labelTotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTotal.Location = new System.Drawing.Point(240, 495);
            this.labelTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(108, 19);
            this.labelTotal.TabIndex = 12;
            this.labelTotal.Text = "materialLabel4";
            // 
            // label_total
            // 
            this.label_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_total.AutoSize = true;
            this.label_total.Depth = 0;
            this.label_total.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_total.Location = new System.Drawing.Point(12, 495);
            this.label_total.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(48, 19);
            this.label_total.TabIndex = 11;
            this.label_total.Text = "Total:";
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(12, 419);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(336, 5);
            this.materialDivider1.TabIndex = 13;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // ViewSalePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 560);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.labelMisc);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.label_misc_charges);
            this.Controls.Add(this.label_subtotal);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.labelSaleDate);
            this.Controls.Add(this.labelSaleId);
            this.Controls.Add(this.labelIssued);
            this.Controls.Add(this.labelSale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(540, 960);
            this.MinimumSize = new System.Drawing.Size(360, 560);
            this.Name = "ViewSalePage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Sale";
            this.Load += new System.EventHandler(this.ViewSalePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelSale;
        private MaterialSkin.Controls.MaterialLabel labelIssued;
        private MaterialSkin.Controls.MaterialLabel labelSaleId;
        private MaterialSkin.Controls.MaterialLabel labelSaleDate;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private MaterialSkin.Controls.MaterialLabel labelMisc;
        private MaterialSkin.Controls.MaterialLabel labelSubtotal;
        private MaterialSkin.Controls.MaterialLabel label_misc_charges;
        private MaterialSkin.Controls.MaterialLabel label_subtotal;
        private MaterialSkin.Controls.MaterialLabel labelTotal;
        private MaterialSkin.Controls.MaterialLabel label_total;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}