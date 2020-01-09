﻿namespace POSINV
{
    partial class InventoryPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryPage));
            this.mtcInventory = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageAddProduct = new System.Windows.Forms.TabPage();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btnSaveProduct = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureProduct = new System.Windows.Forms.PictureBox();
            this.btnAddPicture = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.tabSAddProduct = new MaterialSkin.Controls.MaterialTabSelector();
            this.labelName = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageManageProduct = new System.Windows.Forms.TabPage();
            this.btnUpdateProduct = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDeleteProduct = new MaterialSkin.Controls.MaterialFlatButton();
            this.textSearchProduct = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSearchProduct = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.materialDivider6 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.tabSManageProduct = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPageManageBrand = new System.Windows.Forms.TabPage();
            this.btnUpdateBrand = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDeleteBrand = new MaterialSkin.Controls.MaterialFlatButton();
            this.textSearchBrand = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSearchBrand = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridViewBrand = new System.Windows.Forms.DataGridView();
            this.materialDivider7 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider8 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider9 = new MaterialSkin.Controls.MaterialDivider();
            this.tabSManageBrand = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPageManageCategory = new System.Windows.Forms.TabPage();
            this.btnUpdateCategory = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDeleteCategory = new MaterialSkin.Controls.MaterialFlatButton();
            this.textSearchCategory = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSearchCategory = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.materialDivider10 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider11 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider12 = new MaterialSkin.Controls.MaterialDivider();
            this.tabSManageCategory = new MaterialSkin.Controls.MaterialTabSelector();
            this.openFilePicture = new System.Windows.Forms.OpenFileDialog();
            this.mtcInventory.SuspendLayout();
            this.tabPageAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).BeginInit();
            this.tabPageManageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.tabPageManageBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrand)).BeginInit();
            this.tabPageManageCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // mtcInventory
            // 
            this.mtcInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtcInventory.Controls.Add(this.tabPageAddProduct);
            this.mtcInventory.Controls.Add(this.tabPageManageProduct);
            this.mtcInventory.Controls.Add(this.tabPageManageBrand);
            this.mtcInventory.Controls.Add(this.tabPageManageCategory);
            this.mtcInventory.Depth = 0;
            this.mtcInventory.Location = new System.Drawing.Point(9, 64);
            this.mtcInventory.Margin = new System.Windows.Forms.Padding(0);
            this.mtcInventory.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtcInventory.Multiline = true;
            this.mtcInventory.Name = "mtcInventory";
            this.mtcInventory.Padding = new System.Drawing.Point(0, 0);
            this.mtcInventory.SelectedIndex = 0;
            this.mtcInventory.Size = new System.Drawing.Size(942, 467);
            this.mtcInventory.TabIndex = 0;
            // 
            // tabPageAddProduct
            // 
            this.tabPageAddProduct.BackColor = System.Drawing.Color.White;
            this.tabPageAddProduct.Controls.Add(this.materialDivider3);
            this.tabPageAddProduct.Controls.Add(this.materialDivider2);
            this.tabPageAddProduct.Controls.Add(this.materialDivider1);
            this.tabPageAddProduct.Controls.Add(this.btnSaveProduct);
            this.tabPageAddProduct.Controls.Add(this.pictureProduct);
            this.tabPageAddProduct.Controls.Add(this.btnAddPicture);
            this.tabPageAddProduct.Controls.Add(this.btnAddBrand);
            this.tabPageAddProduct.Controls.Add(this.btnAddCategory);
            this.tabPageAddProduct.Controls.Add(this.labelCategory);
            this.tabPageAddProduct.Controls.Add(this.labelBrand);
            this.tabPageAddProduct.Controls.Add(this.comboCategory);
            this.tabPageAddProduct.Controls.Add(this.comboBrand);
            this.tabPageAddProduct.Controls.Add(this.textDescription);
            this.tabPageAddProduct.Controls.Add(this.labelDescription);
            this.tabPageAddProduct.Controls.Add(this.textQuantity);
            this.tabPageAddProduct.Controls.Add(this.labelQuantity);
            this.tabPageAddProduct.Controls.Add(this.textList);
            this.tabPageAddProduct.Controls.Add(this.labelList);
            this.tabPageAddProduct.Controls.Add(this.textCost);
            this.tabPageAddProduct.Controls.Add(this.labelCost);
            this.tabPageAddProduct.Controls.Add(this.textName);
            this.tabPageAddProduct.Controls.Add(this.tabSAddProduct);
            this.tabPageAddProduct.Controls.Add(this.labelName);
            this.tabPageAddProduct.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddProduct.Name = "tabPageAddProduct";
            this.tabPageAddProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddProduct.Size = new System.Drawing.Size(934, 441);
            this.tabPageAddProduct.TabIndex = 0;
            this.tabPageAddProduct.Text = "Add Product";
            this.tabPageAddProduct.Click += new System.EventHandler(this.tabPageAddProduct_Click);
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialDivider3.Location = new System.Drawing.Point(921, 51);
            this.materialDivider3.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(10, 377);
            this.materialDivider3.TabIndex = 25;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialDivider2.Location = new System.Drawing.Point(3, 51);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(10, 377);
            this.materialDivider2.TabIndex = 24;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialDivider1.Location = new System.Drawing.Point(3, 428);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(928, 10);
            this.materialDivider1.TabIndex = 23;
            this.materialDivider1.Text = "materialDivider1";
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
            this.btnSaveProduct.TabIndex = 22;
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
            this.pictureProduct.Location = new System.Drawing.Point(526, 146);
            this.pictureProduct.MaximumSize = new System.Drawing.Size(480, 480);
            this.pictureProduct.MinimumSize = new System.Drawing.Size(192, 192);
            this.pictureProduct.Name = "pictureProduct";
            this.pictureProduct.Size = new System.Drawing.Size(200, 200);
            this.pictureProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureProduct.TabIndex = 21;
            this.pictureProduct.TabStop = false;
            this.pictureProduct.Click += new System.EventHandler(this.pictureProduct_Click);
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
            this.btnAddPicture.TabIndex = 20;
            this.btnAddPicture.Text = "Add Picture";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
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
            this.btnAddBrand.TabIndex = 19;
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
            this.btnAddCategory.Location = new System.Drawing.Point(283, 360);
            this.btnAddCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Primary = true;
            this.btnAddCategory.Size = new System.Drawing.Size(154, 36);
            this.btnAddCategory.TabIndex = 18;
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
            this.labelCategory.Location = new System.Drawing.Point(279, 308);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(3);
            this.labelCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(79, 19);
            this.labelCategory.TabIndex = 14;
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
            this.labelBrand.TabIndex = 13;
            this.labelBrand.Text = "Brand *";
            this.labelBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBrand.Click += new System.EventHandler(this.labelBrand_Click);
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
            this.comboCategory.TabIndex = 12;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
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
            this.comboBrand.TabIndex = 11;
            this.comboBrand.SelectedIndexChanged += new System.EventHandler(this.comboBrand_SelectedIndexChanged);
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
            this.textDescription.TabIndex = 10;
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
            this.labelDescription.TabIndex = 9;
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
            this.textQuantity.TabIndex = 8;
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
            this.labelQuantity.TabIndex = 7;
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
            this.textList.TabIndex = 6;
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
            this.labelList.TabIndex = 5;
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
            this.textCost.TabIndex = 4;
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
            this.labelCost.TabIndex = 3;
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
            this.textName.TabIndex = 2;
            this.textName.TabStop = false;
            this.textName.UseSystemPasswordChar = false;
            this.textName.Click += new System.EventHandler(this.textName_Click);
            // 
            // tabSAddProduct
            // 
            this.tabSAddProduct.BaseTabControl = this.mtcInventory;
            this.tabSAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabSAddProduct.Depth = 0;
            this.tabSAddProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSAddProduct.Location = new System.Drawing.Point(3, 3);
            this.tabSAddProduct.Margin = new System.Windows.Forms.Padding(0);
            this.tabSAddProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSAddProduct.Name = "tabSAddProduct";
            this.tabSAddProduct.Size = new System.Drawing.Size(928, 48);
            this.tabSAddProduct.TabIndex = 1;
            this.tabSAddProduct.Text = "materialTabSelector2";
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
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Product Name *";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // tabPageManageProduct
            // 
            this.tabPageManageProduct.BackColor = System.Drawing.Color.White;
            this.tabPageManageProduct.Controls.Add(this.btnUpdateProduct);
            this.tabPageManageProduct.Controls.Add(this.btnDeleteProduct);
            this.tabPageManageProduct.Controls.Add(this.textSearchProduct);
            this.tabPageManageProduct.Controls.Add(this.btnSearchProduct);
            this.tabPageManageProduct.Controls.Add(this.dataGridViewProduct);
            this.tabPageManageProduct.Controls.Add(this.materialDivider6);
            this.tabPageManageProduct.Controls.Add(this.materialDivider5);
            this.tabPageManageProduct.Controls.Add(this.materialDivider4);
            this.tabPageManageProduct.Controls.Add(this.tabSManageProduct);
            this.tabPageManageProduct.Location = new System.Drawing.Point(4, 22);
            this.tabPageManageProduct.Name = "tabPageManageProduct";
            this.tabPageManageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManageProduct.Size = new System.Drawing.Size(934, 441);
            this.tabPageManageProduct.TabIndex = 1;
            this.tabPageManageProduct.Text = "Manage Products";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateProduct.AutoSize = true;
            this.btnUpdateProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateProduct.Depth = 0;
            this.btnUpdateProduct.Icon = null;
            this.btnUpdateProduct.Location = new System.Drawing.Point(328, 69);
            this.btnUpdateProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Primary = false;
            this.btnUpdateProduct.Size = new System.Drawing.Size(73, 36);
            this.btnUpdateProduct.TabIndex = 15;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProduct.AutoSize = true;
            this.btnDeleteProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteProduct.Depth = 0;
            this.btnDeleteProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDeleteProduct.Icon = null;
            this.btnDeleteProduct.Location = new System.Drawing.Point(409, 69);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Primary = false;
            this.btnDeleteProduct.Size = new System.Drawing.Size(69, 36);
            this.btnDeleteProduct.TabIndex = 8;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // textSearchProduct
            // 
            this.textSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearchProduct.Depth = 0;
            this.textSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchProduct.Hint = "Product Name";
            this.textSearchProduct.Location = new System.Drawing.Point(530, 82);
            this.textSearchProduct.MaxLength = 32767;
            this.textSearchProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.textSearchProduct.Name = "textSearchProduct";
            this.textSearchProduct.PasswordChar = '\0';
            this.textSearchProduct.SelectedText = "";
            this.textSearchProduct.SelectionLength = 0;
            this.textSearchProduct.SelectionStart = 0;
            this.textSearchProduct.Size = new System.Drawing.Size(185, 23);
            this.textSearchProduct.TabIndex = 7;
            this.textSearchProduct.TabStop = false;
            this.textSearchProduct.UseSystemPasswordChar = false;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchProduct.AutoSize = true;
            this.btnSearchProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchProduct.Depth = 0;
            this.btnSearchProduct.Icon = null;
            this.btnSearchProduct.Location = new System.Drawing.Point(721, 69);
            this.btnSearchProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Primary = true;
            this.btnSearchProduct.Size = new System.Drawing.Size(73, 36);
            this.btnSearchProduct.TabIndex = 6;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewProduct.Location = new System.Drawing.Point(171, 136);
            this.dataGridViewProduct.MultiSelect = false;
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            this.dataGridViewProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewProduct.Size = new System.Drawing.Size(744, 286);
            this.dataGridViewProduct.TabIndex = 5;
            this.dataGridViewProduct.Click += new System.EventHandler(this.dataGridViewProduct_Click);
            // 
            // materialDivider6
            // 
            this.materialDivider6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider6.Depth = 0;
            this.materialDivider6.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialDivider6.Location = new System.Drawing.Point(3, 51);
            this.materialDivider6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider6.Name = "materialDivider6";
            this.materialDivider6.Size = new System.Drawing.Size(10, 377);
            this.materialDivider6.TabIndex = 4;
            this.materialDivider6.Text = "materialDivider6";
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialDivider5.Location = new System.Drawing.Point(921, 51);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(10, 377);
            this.materialDivider5.TabIndex = 3;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialDivider4.Location = new System.Drawing.Point(3, 428);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(928, 10);
            this.materialDivider4.TabIndex = 2;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // tabSManageProduct
            // 
            this.tabSManageProduct.BaseTabControl = this.mtcInventory;
            this.tabSManageProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabSManageProduct.Depth = 0;
            this.tabSManageProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSManageProduct.Location = new System.Drawing.Point(3, 3);
            this.tabSManageProduct.Margin = new System.Windows.Forms.Padding(0);
            this.tabSManageProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSManageProduct.Name = "tabSManageProduct";
            this.tabSManageProduct.Size = new System.Drawing.Size(928, 48);
            this.tabSManageProduct.TabIndex = 1;
            this.tabSManageProduct.Text = "materialTabSelector1";
            // 
            // tabPageManageBrand
            // 
            this.tabPageManageBrand.BackColor = System.Drawing.Color.White;
            this.tabPageManageBrand.Controls.Add(this.btnUpdateBrand);
            this.tabPageManageBrand.Controls.Add(this.btnDeleteBrand);
            this.tabPageManageBrand.Controls.Add(this.textSearchBrand);
            this.tabPageManageBrand.Controls.Add(this.btnSearchBrand);
            this.tabPageManageBrand.Controls.Add(this.dataGridViewBrand);
            this.tabPageManageBrand.Controls.Add(this.materialDivider7);
            this.tabPageManageBrand.Controls.Add(this.materialDivider8);
            this.tabPageManageBrand.Controls.Add(this.materialDivider9);
            this.tabPageManageBrand.Controls.Add(this.tabSManageBrand);
            this.tabPageManageBrand.Location = new System.Drawing.Point(4, 22);
            this.tabPageManageBrand.Name = "tabPageManageBrand";
            this.tabPageManageBrand.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManageBrand.Size = new System.Drawing.Size(934, 441);
            this.tabPageManageBrand.TabIndex = 2;
            this.tabPageManageBrand.Text = "Manage Brands";
            // 
            // btnUpdateBrand
            // 
            this.btnUpdateBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateBrand.AutoSize = true;
            this.btnUpdateBrand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateBrand.Depth = 0;
            this.btnUpdateBrand.Icon = null;
            this.btnUpdateBrand.Location = new System.Drawing.Point(328, 69);
            this.btnUpdateBrand.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateBrand.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateBrand.Name = "btnUpdateBrand";
            this.btnUpdateBrand.Primary = false;
            this.btnUpdateBrand.Size = new System.Drawing.Size(73, 36);
            this.btnUpdateBrand.TabIndex = 15;
            this.btnUpdateBrand.Text = "Update";
            this.btnUpdateBrand.UseVisualStyleBackColor = true;
            this.btnUpdateBrand.Click += new System.EventHandler(this.btnUpdateBrand_Click);
            // 
            // btnDeleteBrand
            // 
            this.btnDeleteBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBrand.AutoSize = true;
            this.btnDeleteBrand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteBrand.Depth = 0;
            this.btnDeleteBrand.Icon = null;
            this.btnDeleteBrand.Location = new System.Drawing.Point(409, 69);
            this.btnDeleteBrand.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteBrand.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteBrand.Name = "btnDeleteBrand";
            this.btnDeleteBrand.Primary = false;
            this.btnDeleteBrand.Size = new System.Drawing.Size(69, 36);
            this.btnDeleteBrand.TabIndex = 11;
            this.btnDeleteBrand.Text = "Delete";
            this.btnDeleteBrand.UseVisualStyleBackColor = true;
            this.btnDeleteBrand.Click += new System.EventHandler(this.btnDeleteBrand_Click);
            // 
            // textSearchBrand
            // 
            this.textSearchBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearchBrand.Depth = 0;
            this.textSearchBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchBrand.Hint = "Brand Name";
            this.textSearchBrand.Location = new System.Drawing.Point(530, 82);
            this.textSearchBrand.MaxLength = 32767;
            this.textSearchBrand.MouseState = MaterialSkin.MouseState.HOVER;
            this.textSearchBrand.Name = "textSearchBrand";
            this.textSearchBrand.PasswordChar = '\0';
            this.textSearchBrand.SelectedText = "";
            this.textSearchBrand.SelectionLength = 0;
            this.textSearchBrand.SelectionStart = 0;
            this.textSearchBrand.Size = new System.Drawing.Size(185, 23);
            this.textSearchBrand.TabIndex = 10;
            this.textSearchBrand.TabStop = false;
            this.textSearchBrand.UseSystemPasswordChar = false;
            // 
            // btnSearchBrand
            // 
            this.btnSearchBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchBrand.AutoSize = true;
            this.btnSearchBrand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchBrand.Depth = 0;
            this.btnSearchBrand.Icon = null;
            this.btnSearchBrand.Location = new System.Drawing.Point(721, 69);
            this.btnSearchBrand.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearchBrand.Name = "btnSearchBrand";
            this.btnSearchBrand.Primary = true;
            this.btnSearchBrand.Size = new System.Drawing.Size(73, 36);
            this.btnSearchBrand.TabIndex = 9;
            this.btnSearchBrand.Text = "Search";
            this.btnSearchBrand.UseVisualStyleBackColor = true;
            this.btnSearchBrand.Click += new System.EventHandler(this.btnSearchBrand_Click);
            // 
            // dataGridViewBrand
            // 
            this.dataGridViewBrand.AllowUserToAddRows = false;
            this.dataGridViewBrand.AllowUserToDeleteRows = false;
            this.dataGridViewBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBrand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBrand.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBrand.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewBrand.Location = new System.Drawing.Point(171, 136);
            this.dataGridViewBrand.MultiSelect = false;
            this.dataGridViewBrand.Name = "dataGridViewBrand";
            this.dataGridViewBrand.ReadOnly = true;
            this.dataGridViewBrand.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewBrand.Size = new System.Drawing.Size(744, 286);
            this.dataGridViewBrand.TabIndex = 8;
            // 
            // materialDivider7
            // 
            this.materialDivider7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider7.Depth = 0;
            this.materialDivider7.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialDivider7.Location = new System.Drawing.Point(3, 51);
            this.materialDivider7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider7.Name = "materialDivider7";
            this.materialDivider7.Size = new System.Drawing.Size(10, 377);
            this.materialDivider7.TabIndex = 7;
            this.materialDivider7.Text = "materialDivider7";
            // 
            // materialDivider8
            // 
            this.materialDivider8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider8.Depth = 0;
            this.materialDivider8.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialDivider8.Location = new System.Drawing.Point(921, 51);
            this.materialDivider8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider8.Name = "materialDivider8";
            this.materialDivider8.Size = new System.Drawing.Size(10, 377);
            this.materialDivider8.TabIndex = 6;
            this.materialDivider8.Text = "materialDivider8";
            // 
            // materialDivider9
            // 
            this.materialDivider9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider9.Depth = 0;
            this.materialDivider9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialDivider9.Location = new System.Drawing.Point(3, 428);
            this.materialDivider9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider9.Name = "materialDivider9";
            this.materialDivider9.Size = new System.Drawing.Size(928, 10);
            this.materialDivider9.TabIndex = 5;
            this.materialDivider9.Text = "materialDivider9";
            // 
            // tabSManageBrand
            // 
            this.tabSManageBrand.BaseTabControl = this.mtcInventory;
            this.tabSManageBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabSManageBrand.Depth = 0;
            this.tabSManageBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSManageBrand.Location = new System.Drawing.Point(3, 3);
            this.tabSManageBrand.Margin = new System.Windows.Forms.Padding(0);
            this.tabSManageBrand.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSManageBrand.Name = "tabSManageBrand";
            this.tabSManageBrand.Size = new System.Drawing.Size(928, 48);
            this.tabSManageBrand.TabIndex = 2;
            this.tabSManageBrand.Text = "materialTabSelector2";
            // 
            // tabPageManageCategory
            // 
            this.tabPageManageCategory.BackColor = System.Drawing.Color.White;
            this.tabPageManageCategory.Controls.Add(this.btnUpdateCategory);
            this.tabPageManageCategory.Controls.Add(this.btnDeleteCategory);
            this.tabPageManageCategory.Controls.Add(this.textSearchCategory);
            this.tabPageManageCategory.Controls.Add(this.btnSearchCategory);
            this.tabPageManageCategory.Controls.Add(this.dataGridViewCategory);
            this.tabPageManageCategory.Controls.Add(this.materialDivider10);
            this.tabPageManageCategory.Controls.Add(this.materialDivider11);
            this.tabPageManageCategory.Controls.Add(this.materialDivider12);
            this.tabPageManageCategory.Controls.Add(this.tabSManageCategory);
            this.tabPageManageCategory.Location = new System.Drawing.Point(4, 22);
            this.tabPageManageCategory.Name = "tabPageManageCategory";
            this.tabPageManageCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManageCategory.Size = new System.Drawing.Size(934, 441);
            this.tabPageManageCategory.TabIndex = 3;
            this.tabPageManageCategory.Text = "Manage Categories";
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateCategory.AutoSize = true;
            this.btnUpdateCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateCategory.Depth = 0;
            this.btnUpdateCategory.Icon = null;
            this.btnUpdateCategory.Location = new System.Drawing.Point(328, 69);
            this.btnUpdateCategory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Primary = false;
            this.btnUpdateCategory.Size = new System.Drawing.Size(73, 36);
            this.btnUpdateCategory.TabIndex = 14;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCategory.AutoSize = true;
            this.btnDeleteCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteCategory.Depth = 0;
            this.btnDeleteCategory.Icon = null;
            this.btnDeleteCategory.Location = new System.Drawing.Point(409, 69);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Primary = false;
            this.btnDeleteCategory.Size = new System.Drawing.Size(69, 36);
            this.btnDeleteCategory.TabIndex = 13;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // textSearchCategory
            // 
            this.textSearchCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearchCategory.Depth = 0;
            this.textSearchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchCategory.Hint = "Category Name";
            this.textSearchCategory.Location = new System.Drawing.Point(530, 82);
            this.textSearchCategory.MaxLength = 32767;
            this.textSearchCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.textSearchCategory.Name = "textSearchCategory";
            this.textSearchCategory.PasswordChar = '\0';
            this.textSearchCategory.SelectedText = "";
            this.textSearchCategory.SelectionLength = 0;
            this.textSearchCategory.SelectionStart = 0;
            this.textSearchCategory.Size = new System.Drawing.Size(185, 23);
            this.textSearchCategory.TabIndex = 10;
            this.textSearchCategory.TabStop = false;
            this.textSearchCategory.UseSystemPasswordChar = false;
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchCategory.AutoSize = true;
            this.btnSearchCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchCategory.Depth = 0;
            this.btnSearchCategory.Icon = null;
            this.btnSearchCategory.Location = new System.Drawing.Point(721, 69);
            this.btnSearchCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Primary = true;
            this.btnSearchCategory.Size = new System.Drawing.Size(73, 36);
            this.btnSearchCategory.TabIndex = 9;
            this.btnSearchCategory.Text = "Search";
            this.btnSearchCategory.UseVisualStyleBackColor = true;
            this.btnSearchCategory.Click += new System.EventHandler(this.btnSearchCategory_Click);
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.AllowUserToAddRows = false;
            this.dataGridViewCategory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dataGridViewCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCategory.Location = new System.Drawing.Point(171, 136);
            this.dataGridViewCategory.MultiSelect = false;
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.ReadOnly = true;
            this.dataGridViewCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewCategory.Size = new System.Drawing.Size(744, 286);
            this.dataGridViewCategory.TabIndex = 8;
            // 
            // materialDivider10
            // 
            this.materialDivider10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider10.Depth = 0;
            this.materialDivider10.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialDivider10.Location = new System.Drawing.Point(3, 51);
            this.materialDivider10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider10.Name = "materialDivider10";
            this.materialDivider10.Size = new System.Drawing.Size(10, 377);
            this.materialDivider10.TabIndex = 7;
            this.materialDivider10.Text = "materialDivider10";
            // 
            // materialDivider11
            // 
            this.materialDivider11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider11.Depth = 0;
            this.materialDivider11.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialDivider11.Location = new System.Drawing.Point(921, 51);
            this.materialDivider11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider11.Name = "materialDivider11";
            this.materialDivider11.Size = new System.Drawing.Size(10, 377);
            this.materialDivider11.TabIndex = 6;
            this.materialDivider11.Text = "materialDivider11";
            // 
            // materialDivider12
            // 
            this.materialDivider12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider12.Depth = 0;
            this.materialDivider12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialDivider12.Location = new System.Drawing.Point(3, 428);
            this.materialDivider12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider12.Name = "materialDivider12";
            this.materialDivider12.Size = new System.Drawing.Size(928, 10);
            this.materialDivider12.TabIndex = 5;
            this.materialDivider12.Text = "materialDivider12";
            // 
            // tabSManageCategory
            // 
            this.tabSManageCategory.BaseTabControl = this.mtcInventory;
            this.tabSManageCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabSManageCategory.Depth = 0;
            this.tabSManageCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSManageCategory.Location = new System.Drawing.Point(3, 3);
            this.tabSManageCategory.Margin = new System.Windows.Forms.Padding(0);
            this.tabSManageCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSManageCategory.Name = "tabSManageCategory";
            this.tabSManageCategory.Size = new System.Drawing.Size(928, 48);
            this.tabSManageCategory.TabIndex = 2;
            this.tabSManageCategory.Text = "materialTabSelector2";
            // 
            // openFilePicture
            // 
            this.openFilePicture.Filter = "\"Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif" +
    "; *.png;\"";
            this.openFilePicture.Title = "Select A Picture For The Product";
            this.openFilePicture.FileOk += new System.ComponentModel.CancelEventHandler(this.openFilePicture_FileOk);
            // 
            // InventoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.mtcInventory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "InventoryPage";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Inventory";
            this.Load += new System.EventHandler(this.InventoryPage_Load);
            this.mtcInventory.ResumeLayout(false);
            this.tabPageAddProduct.ResumeLayout(false);
            this.tabPageAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).EndInit();
            this.tabPageManageProduct.ResumeLayout(false);
            this.tabPageManageProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.tabPageManageBrand.ResumeLayout(false);
            this.tabPageManageBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrand)).EndInit();
            this.tabPageManageCategory.ResumeLayout(false);
            this.tabPageManageCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mtcInventory;
        private System.Windows.Forms.TabPage tabPageAddProduct;
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
        private MaterialSkin.Controls.MaterialTabSelector tabSAddProduct;
        private MaterialSkin.Controls.MaterialLabel labelName;
        private System.Windows.Forms.TabPage tabPageManageProduct;
        private MaterialSkin.Controls.MaterialTabSelector tabSManageProduct;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddBrand;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddCategory;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddPicture;
        private System.Windows.Forms.PictureBox pictureProduct;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaveProduct;
        private System.Windows.Forms.OpenFileDialog openFilePicture;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider6;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private System.Windows.Forms.TabPage tabPageManageBrand;
        private System.Windows.Forms.TabPage tabPageManageCategory;
        private MaterialSkin.Controls.MaterialTabSelector tabSManageBrand;
        private MaterialSkin.Controls.MaterialTabSelector tabSManageCategory;
        private MaterialSkin.Controls.MaterialDivider materialDivider7;
        private MaterialSkin.Controls.MaterialDivider materialDivider8;
        private MaterialSkin.Controls.MaterialDivider materialDivider9;
        private MaterialSkin.Controls.MaterialDivider materialDivider10;
        private MaterialSkin.Controls.MaterialDivider materialDivider11;
        private MaterialSkin.Controls.MaterialDivider materialDivider12;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.DataGridView dataGridViewBrand;
        private System.Windows.Forms.DataGridView dataGridViewCategory;
        private MaterialSkin.Controls.MaterialRaisedButton btnSearchProduct;
        private MaterialSkin.Controls.MaterialSingleLineTextField textSearchProduct;
        private MaterialSkin.Controls.MaterialSingleLineTextField textSearchBrand;
        private MaterialSkin.Controls.MaterialRaisedButton btnSearchBrand;
        private MaterialSkin.Controls.MaterialSingleLineTextField textSearchCategory;
        private MaterialSkin.Controls.MaterialRaisedButton btnSearchCategory;
        private MaterialSkin.Controls.MaterialFlatButton btnDeleteProduct;
        private MaterialSkin.Controls.MaterialFlatButton btnDeleteBrand;
        private MaterialSkin.Controls.MaterialFlatButton btnDeleteCategory;
        private MaterialSkin.Controls.MaterialFlatButton btnUpdateCategory;
        private MaterialSkin.Controls.MaterialFlatButton btnUpdateProduct;
        private MaterialSkin.Controls.MaterialFlatButton btnUpdateBrand;
    }
}