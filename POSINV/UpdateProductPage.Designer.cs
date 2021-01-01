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
            this.openFilePicture = new System.Windows.Forms.OpenFileDialog();
            this.textSKU = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelSKU = new MaterialSkin.Controls.MaterialLabel();
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
            this.btnAddBrand.Location = new System.Drawing.Point(377, 324);
            this.btnAddBrand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddBrand.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Primary = true;
            this.btnAddBrand.Size = new System.Drawing.Size(158, 36);
            this.btnAddBrand.TabIndex = 35;
            this.btnAddBrand.Text = "Add New Brand";
            this.btnAddBrand.UseVisualStyleBackColor = true;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddCategory.AutoSize = true;
            this.btnAddCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCategory.Depth = 0;
            this.btnAddCategory.Icon = null;
            this.btnAddCategory.Location = new System.Drawing.Point(377, 470);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Primary = true;
            this.btnAddCategory.Size = new System.Drawing.Size(189, 36);
            this.btnAddCategory.TabIndex = 34;
            this.btnAddCategory.Text = "Add New Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCategory.AutoSize = true;
            this.labelCategory.Depth = 0;
            this.labelCategory.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCategory.Location = new System.Drawing.Point(372, 406);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(98, 24);
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
            this.labelBrand.Location = new System.Drawing.Point(372, 260);
            this.labelBrand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelBrand.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(72, 24);
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
            this.comboCategory.Location = new System.Drawing.Point(377, 437);
            this.comboCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(204, 24);
            this.comboCategory.TabIndex = 31;
            // 
            // comboBrand
            // 
            this.comboBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBrand.FormattingEnabled = true;
            this.comboBrand.Location = new System.Drawing.Point(377, 290);
            this.comboBrand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBrand.Name = "comboBrand";
            this.comboBrand.Size = new System.Drawing.Size(172, 24);
            this.comboBrand.TabIndex = 30;
            // 
            // textDescription
            // 
            this.textDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textDescription.Depth = 0;
            this.textDescription.Hint = "(Variant, Specs)";
            this.textDescription.Location = new System.Drawing.Point(377, 123);
            this.textDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textDescription.MaxLength = 1000;
            this.textDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.textDescription.Name = "textDescription";
            this.textDescription.PasswordChar = '\0';
            this.textDescription.SelectedText = "";
            this.textDescription.SelectionLength = 0;
            this.textDescription.SelectionStart = 0;
            this.textDescription.Size = new System.Drawing.Size(175, 28);
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
            this.labelDescription.Location = new System.Drawing.Point(372, 92);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(106, 24);
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
            this.textQuantity.Location = new System.Drawing.Point(116, 477);
            this.textQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textQuantity.MaxLength = 10;
            this.textQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.PasswordChar = '\0';
            this.textQuantity.SelectedText = "";
            this.textQuantity.SelectionLength = 0;
            this.textQuantity.SelectionStart = 0;
            this.textQuantity.Size = new System.Drawing.Size(135, 28);
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
            this.labelQuantity.Location = new System.Drawing.Point(111, 447);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(92, 24);
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
            this.textList.Location = new System.Drawing.Point(116, 380);
            this.textList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textList.MaxLength = 10;
            this.textList.MouseState = MaterialSkin.MouseState.HOVER;
            this.textList.Name = "textList";
            this.textList.PasswordChar = '\0';
            this.textList.SelectedText = "";
            this.textList.SelectionLength = 0;
            this.textList.SelectionStart = 0;
            this.textList.Size = new System.Drawing.Size(135, 28);
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
            this.labelList.Location = new System.Drawing.Point(111, 349);
            this.labelList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelList.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(102, 24);
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
            this.textCost.Location = new System.Drawing.Point(116, 283);
            this.textCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCost.MaxLength = 10;
            this.textCost.MouseState = MaterialSkin.MouseState.HOVER;
            this.textCost.Name = "textCost";
            this.textCost.PasswordChar = '\0';
            this.textCost.SelectedText = "";
            this.textCost.SelectionLength = 0;
            this.textCost.SelectionStart = 0;
            this.textCost.Size = new System.Drawing.Size(135, 28);
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
            this.labelCost.Location = new System.Drawing.Point(111, 252);
            this.labelCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelCost.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(110, 24);
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
            this.textName.Location = new System.Drawing.Point(116, 123);
            this.textName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textName.MaxLength = 100;
            this.textName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textName.Name = "textName";
            this.textName.PasswordChar = '\0';
            this.textName.SelectedText = "";
            this.textName.SelectionLength = 0;
            this.textName.SelectionStart = 0;
            this.textName.Size = new System.Drawing.Size(135, 28);
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
            this.labelName.Location = new System.Drawing.Point(111, 92);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelName.MaximumSize = new System.Drawing.Size(280, 47);
            this.labelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(145, 24);
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
            this.btnSaveProduct.Location = new System.Drawing.Point(1025, 470);
            this.btnSaveProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Primary = true;
            this.btnSaveProduct.Size = new System.Drawing.Size(146, 36);
            this.btnSaveProduct.TabIndex = 41;
            this.btnSaveProduct.Text = "Save Product";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // pictureProduct
            // 
            this.pictureProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureProduct.BackColor = System.Drawing.Color.Transparent;
            this.pictureProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureProduct.Location = new System.Drawing.Point(701, 180);
            this.pictureProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureProduct.MaximumSize = new System.Drawing.Size(639, 590);
            this.pictureProduct.MinimumSize = new System.Drawing.Size(255, 236);
            this.pictureProduct.Name = "pictureProduct";
            this.pictureProduct.Size = new System.Drawing.Size(266, 246);
            this.pictureProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProduct.TabIndex = 40;
            this.pictureProduct.TabStop = false;
            this.pictureProduct.Click += new System.EventHandler(this.pictureProduct_Click);
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.AutoSize = true;
            this.btnAddPicture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddPicture.Depth = 0;
            this.btnAddPicture.Icon = null;
            this.btnAddPicture.Location = new System.Drawing.Point(701, 128);
            this.btnAddPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPicture.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Primary = true;
            this.btnAddPicture.Size = new System.Drawing.Size(129, 36);
            this.btnAddPicture.TabIndex = 39;
            this.btnAddPicture.Text = "Add Picture";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // openFilePicture
            // 
            this.openFilePicture.Filter = "\"Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif" +
    "; *.png;\"";
            this.openFilePicture.Title = "Select A Picture For The Product";
            // 
            // textSKU
            // 
            this.textSKU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textSKU.Depth = 0;
            this.textSKU.Hint = "AG-420";
            this.textSKU.Location = new System.Drawing.Point(116, 198);
            this.textSKU.Margin = new System.Windows.Forms.Padding(4);
            this.textSKU.MaxLength = 100;
            this.textSKU.MouseState = MaterialSkin.MouseState.HOVER;
            this.textSKU.Name = "textSKU";
            this.textSKU.PasswordChar = '\0';
            this.textSKU.SelectedText = "";
            this.textSKU.SelectionLength = 0;
            this.textSKU.SelectionStart = 0;
            this.textSKU.Size = new System.Drawing.Size(135, 28);
            this.textSKU.TabIndex = 22;
            this.textSKU.TabStop = false;
            this.textSKU.UseSystemPasswordChar = false;
            // 
            // labelSKU
            // 
            this.labelSKU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSKU.AutoSize = true;
            this.labelSKU.Depth = 0;
            this.labelSKU.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelSKU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSKU.Location = new System.Drawing.Point(111, 167);
            this.labelSKU.Margin = new System.Windows.Forms.Padding(4);
            this.labelSKU.MaximumSize = new System.Drawing.Size(280, 47);
            this.labelSKU.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSKU.Name = "labelSKU";
            this.labelSKU.Size = new System.Drawing.Size(58, 24);
            this.labelSKU.TabIndex = 42;
            this.labelSKU.Text = "SKU *";
            this.labelSKU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 543);
            this.Controls.Add(this.textSKU);
            this.Controls.Add(this.labelSKU);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1245, 543);
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
        private System.Windows.Forms.OpenFileDialog openFilePicture;
        private MaterialSkin.Controls.MaterialSingleLineTextField textSKU;
        private MaterialSkin.Controls.MaterialLabel labelSKU;
    }
}