namespace POSINV
{
    partial class UpdateProductPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProductPage));
            this.btnAddBrand = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAddCategory = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelCategory = new MaterialSkin.Controls.MaterialLabel();
            this.labelBrand = new MaterialSkin.Controls.MaterialLabel();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.comboBrand = new System.Windows.Forms.ComboBox();
            this.textDescription = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelDescription = new MaterialSkin.Controls.MaterialLabel();
            this.textQuantity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelQuantity = new MaterialSkin.Controls.MaterialLabel();
            this.textList = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelList = new MaterialSkin.Controls.MaterialLabel();
            this.textCost = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelCost = new MaterialSkin.Controls.MaterialLabel();
            this.textName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelName = new MaterialSkin.Controls.MaterialLabel();
            this.btnSaveProduct = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureProduct = new System.Windows.Forms.PictureBox();
            this.btnAddPicture = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddBrand.AutoSize = true;
            this.btnAddBrand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddBrand.Depth = 0;
            this.btnAddBrand.Icon = null;
            this.btnAddBrand.Location = new System.Drawing.Point(283, 241);
            this.btnAddBrand.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Primary = true;
            this.btnAddBrand.Size = new System.Drawing.Size(130, 36);
            this.btnAddBrand.TabIndex = 35;
            this.btnAddBrand.Text = "Add New Brand";
            this.btnAddBrand.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddCategory.AutoSize = true;
            this.btnAddCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCategory.Depth = 0;
            this.btnAddCategory.Icon = null;
            this.btnAddCategory.Location = new System.Drawing.Point(283, 360);
            this.btnAddCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Primary = true;
            this.btnAddCategory.Size = new System.Drawing.Size(154, 36);
            this.btnAddCategory.TabIndex = 34;
            this.btnAddCategory.Text = "Add New Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // labelCategory
            // 
            this.labelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCategory.AutoSize = true;
            this.labelCategory.Depth = 0;
            this.labelCategory.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCategory.Location = new System.Drawing.Point(279, 308);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(3);
            this.labelCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(79, 19);
            this.labelCategory.TabIndex = 33;
            this.labelCategory.Text = "Category *";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBrand
            // 
            this.labelBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBrand.AutoSize = true;
            this.labelBrand.Depth = 0;
            this.labelBrand.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelBrand.Location = new System.Drawing.Point(279, 189);
            this.labelBrand.Margin = new System.Windows.Forms.Padding(3);
            this.labelBrand.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(57, 19);
            this.labelBrand.TabIndex = 32;
            this.labelBrand.Text = "Brand *";
            this.labelBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboCategory
            // 
            this.comboCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(283, 333);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(154, 21);
            this.comboCategory.TabIndex = 31;
            // 
            // comboBrand
            // 
            this.comboBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBrand.FormattingEnabled = true;
            this.comboBrand.Location = new System.Drawing.Point(283, 214);
            this.comboBrand.Name = "comboBrand";
            this.comboBrand.Size = new System.Drawing.Size(130, 21);
            this.comboBrand.TabIndex = 30;
            // 
            // textDescription
            // 
            this.textDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textDescription.Depth = 0;
            this.textDescription.Hint = "(Variant, Specs)";
            this.textDescription.Location = new System.Drawing.Point(283, 129);
            this.textDescription.MaxLength = 1000;
            this.textDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.textDescription.Name = "textDescription";
            this.textDescription.PasswordChar = '\0';
            this.textDescription.SelectedText = "";
            this.textDescription.SelectionLength = 0;
            this.textDescription.SelectionStart = 0;
            this.textDescription.Size = new System.Drawing.Size(131, 23);
            this.textDescription.TabIndex = 29;
            this.textDescription.TabStop = false;
            this.textDescription.UseSystemPasswordChar = false;
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDescription.AutoSize = true;
            this.labelDescription.Depth = 0;
            this.labelDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDescription.Location = new System.Drawing.Point(279, 104);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(3);
            this.labelDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(86, 19);
            this.labelDescription.TabIndex = 28;
            this.labelDescription.Text = "Description";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textQuantity
            // 
            this.textQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textQuantity.Depth = 0;
            this.textQuantity.Hint = "100";
            this.textQuantity.Location = new System.Drawing.Point(87, 366);
            this.textQuantity.MaxLength = 10;
            this.textQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.PasswordChar = '\0';
            this.textQuantity.SelectedText = "";
            this.textQuantity.SelectionLength = 0;
            this.textQuantity.SelectionStart = 0;
            this.textQuantity.Size = new System.Drawing.Size(101, 23);
            this.textQuantity.TabIndex = 27;
            this.textQuantity.TabStop = false;
            this.textQuantity.UseSystemPasswordChar = false;
            // 
            // labelQuantity
            // 
            this.labelQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Depth = 0;
            this.labelQuantity.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelQuantity.Location = new System.Drawing.Point(83, 341);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(3);
            this.labelQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(74, 19);
            this.labelQuantity.TabIndex = 26;
            this.labelQuantity.Text = "Quantity *";
            this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textList
            // 
            this.textList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textList.Depth = 0;
            this.textList.Hint = "200";
            this.textList.Location = new System.Drawing.Point(87, 287);
            this.textList.MaxLength = 10;
            this.textList.MouseState = MaterialSkin.MouseState.HOVER;
            this.textList.Name = "textList";
            this.textList.PasswordChar = '\0';
            this.textList.SelectedText = "";
            this.textList.SelectionLength = 0;
            this.textList.SelectionStart = 0;
            this.textList.Size = new System.Drawing.Size(101, 23);
            this.textList.TabIndex = 25;
            this.textList.TabStop = false;
            this.textList.UseSystemPasswordChar = false;
            // 
            // labelList
            // 
            this.labelList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelList.AutoSize = true;
            this.labelList.Depth = 0;
            this.labelList.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelList.Location = new System.Drawing.Point(83, 262);
            this.labelList.Margin = new System.Windows.Forms.Padding(3);
            this.labelList.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(82, 19);
            this.labelList.TabIndex = 24;
            this.labelList.Text = "List Price *";
            this.labelList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textCost
            // 
            this.textCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textCost.Depth = 0;
            this.textCost.Hint = "100";
            this.textCost.Location = new System.Drawing.Point(87, 208);
            this.textCost.MaxLength = 10;
            this.textCost.MouseState = MaterialSkin.MouseState.HOVER;
            this.textCost.Name = "textCost";
            this.textCost.PasswordChar = '\0';
            this.textCost.SelectedText = "";
            this.textCost.SelectionLength = 0;
            this.textCost.SelectionStart = 0;
            this.textCost.Size = new System.Drawing.Size(101, 23);
            this.textCost.TabIndex = 23;
            this.textCost.TabStop = false;
            this.textCost.UseSystemPasswordChar = false;
            // 
            // labelCost
            // 
            this.labelCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCost.AutoSize = true;
            this.labelCost.Depth = 0;
            this.labelCost.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCost.Location = new System.Drawing.Point(83, 183);
            this.labelCost.Margin = new System.Windows.Forms.Padding(3);
            this.labelCost.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(89, 19);
            this.labelCost.TabIndex = 22;
            this.labelCost.Text = "Cost Price *";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textName
            // 
            this.textName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textName.Depth = 0;
            this.textName.Hint = "Name";
            this.textName.Location = new System.Drawing.Point(87, 129);
            this.textName.MaxLength = 100;
            this.textName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textName.Name = "textName";
            this.textName.PasswordChar = '\0';
            this.textName.SelectedText = "";
            this.textName.SelectionLength = 0;
            this.textName.SelectionStart = 0;
            this.textName.Size = new System.Drawing.Size(101, 23);
            this.textName.TabIndex = 21;
            this.textName.TabStop = false;
            this.textName.UseSystemPasswordChar = false;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.AutoSize = true;
            this.labelName.Depth = 0;
            this.labelName.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelName.Location = new System.Drawing.Point(83, 104);
            this.labelName.Margin = new System.Windows.Forms.Padding(3);
            this.labelName.MaximumSize = new System.Drawing.Size(210, 38);
            this.labelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(115, 19);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "Product Name *";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveProduct.AutoSize = true;
            this.btnSaveProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveProduct.Depth = 0;
            this.btnSaveProduct.Icon = null;
            this.btnSaveProduct.Location = new System.Drawing.Point(732, 375);
            this.btnSaveProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Primary = true;
            this.btnSaveProduct.Size = new System.Drawing.Size(120, 36);
            this.btnSaveProduct.TabIndex = 41;
            this.btnSaveProduct.Text = "Save Product";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            // 
            // pictureProduct
            // 
            this.pictureProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureProduct.BackColor = System.Drawing.Color.Transparent;
            this.pictureProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureProduct.Location = new System.Drawing.Point(526, 146);
            this.pictureProduct.MaximumSize = new System.Drawing.Size(480, 480);
            this.pictureProduct.MinimumSize = new System.Drawing.Size(192, 192);
            this.pictureProduct.Name = "pictureProduct";
            this.pictureProduct.Size = new System.Drawing.Size(200, 200);
            this.pictureProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureProduct.TabIndex = 40;
            this.pictureProduct.TabStop = false;
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.AutoSize = true;
            this.btnAddPicture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddPicture.Depth = 0;
            this.btnAddPicture.Icon = null;
            this.btnAddPicture.Location = new System.Drawing.Point(526, 104);
            this.btnAddPicture.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Primary = true;
            this.btnAddPicture.Size = new System.Drawing.Size(107, 36);
            this.btnAddPicture.TabIndex = 39;
            this.btnAddPicture.Text = "Add Picture";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            // 
            // UpdateProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 441);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.pictureProduct);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.btnAddBrand);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.comboBrand);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textList);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(934, 441);
            this.Name = "UpdateProductPage";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Product";
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnAddBrand;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddCategory;
        private MaterialSkin.Controls.MaterialLabel labelCategory;
        private MaterialSkin.Controls.MaterialLabel labelBrand;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.ComboBox comboBrand;
        private MaterialSkin.Controls.MaterialSingleLineTextField textDescription;
        private MaterialSkin.Controls.MaterialLabel labelDescription;
        private MaterialSkin.Controls.MaterialSingleLineTextField textQuantity;
        private MaterialSkin.Controls.MaterialLabel labelQuantity;
        private MaterialSkin.Controls.MaterialSingleLineTextField textList;
        private MaterialSkin.Controls.MaterialLabel labelList;
        private MaterialSkin.Controls.MaterialSingleLineTextField textCost;
        private MaterialSkin.Controls.MaterialLabel labelCost;
        private MaterialSkin.Controls.MaterialSingleLineTextField textName;
        private MaterialSkin.Controls.MaterialLabel labelName;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaveProduct;
        private System.Windows.Forms.PictureBox pictureProduct;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddPicture;
    }
}