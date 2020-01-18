namespace POSINV
{
    partial class AddBrandPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBrandPage));
            this.textName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelName = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddBrand = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textName.Depth = 0;
            this.textName.Hint = "Name";
            this.textName.Location = new System.Drawing.Point(19, 110);
            this.textName.MaxLength = 100;
            this.textName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textName.Name = "textName";
            this.textName.PasswordChar = '\0';
            this.textName.SelectedText = "";
            this.textName.SelectionLength = 0;
            this.textName.SelectionStart = 0;
            this.textName.Size = new System.Drawing.Size(154, 23);
            this.textName.TabIndex = 4;
            this.textName.TabStop = false;
            this.textName.UseSystemPasswordChar = false;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Depth = 0;
            this.labelName.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelName.Location = new System.Drawing.Point(15, 85);
            this.labelName.Margin = new System.Windows.Forms.Padding(3);
            this.labelName.MaximumSize = new System.Drawing.Size(210, 38);
            this.labelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(101, 19);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Brand Name *";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBrand.AutoSize = true;
            this.btnAddBrand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddBrand.Depth = 0;
            this.btnAddBrand.Icon = null;
            this.btnAddBrand.Location = new System.Drawing.Point(19, 146);
            this.btnAddBrand.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddBrand.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Padding = new System.Windows.Forms.Padding(10);
            this.btnAddBrand.Primary = true;
            this.btnAddBrand.Size = new System.Drawing.Size(104, 36);
            this.btnAddBrand.TabIndex = 5;
            this.btnAddBrand.Text = "Save Brand";
            this.btnAddBrand.UseVisualStyleBackColor = true;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // AddBrandPage
            // 
            this.AcceptButton = this.btnAddBrand;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 192);
            this.Controls.Add(this.btnAddBrand);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(240, 240);
            this.MinimumSize = new System.Drawing.Size(192, 192);
            this.Name = "AddBrandPage";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Brand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField textName;
        private MaterialSkin.Controls.MaterialLabel labelName;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddBrand;
    }
}