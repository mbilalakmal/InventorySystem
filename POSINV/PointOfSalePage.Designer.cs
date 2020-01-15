namespace POSINV
{
    partial class PointOfSalePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointOfSalePage));
            this.mtcSale = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageAddSale = new System.Windows.Forms.TabPage();
            this.pictureProductPreview = new System.Windows.Forms.PictureBox();
            this.textSearchProduct = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.btnSearchProduct = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.tabSAddSale = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPageManageSale = new System.Windows.Forms.TabPage();
            this.btnUpdateSale = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDeleteSale = new MaterialSkin.Controls.MaterialFlatButton();
            this.textSearchSale = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSearchSale = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridViewSale = new System.Windows.Forms.DataGridView();
            this.materialDivider7 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider8 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider9 = new MaterialSkin.Controls.MaterialDivider();
            this.tabSManageSale = new MaterialSkin.Controls.MaterialTabSelector();
            this.textQuantity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelQuantity = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddToCart = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelSubtotal = new MaterialSkin.Controls.MaterialLabel();
            this.labelSubTotalAmount = new MaterialSkin.Controls.MaterialLabel();
            this.btnCheckOut = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRemoveFromCart = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridViewCartItem = new System.Windows.Forms.DataGridView();
            this.mtcSale.SuspendLayout();
            this.tabPageAddSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProductPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.tabPageManageSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartItem)).BeginInit();
            this.SuspendLayout();
            // 
            // mtcSale
            // 
            this.mtcSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtcSale.Controls.Add(this.tabPageAddSale);
            this.mtcSale.Controls.Add(this.tabPageManageSale);
            this.mtcSale.Depth = 0;
            this.mtcSale.Location = new System.Drawing.Point(9, 64);
            this.mtcSale.Margin = new System.Windows.Forms.Padding(0);
            this.mtcSale.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtcSale.Multiline = true;
            this.mtcSale.Name = "mtcSale";
            this.mtcSale.Padding = new System.Drawing.Point(0, 0);
            this.mtcSale.SelectedIndex = 0;
            this.mtcSale.Size = new System.Drawing.Size(942, 467);
            this.mtcSale.TabIndex = 1;
            // 
            // tabPageAddSale
            // 
            this.tabPageAddSale.BackColor = System.Drawing.Color.White;
            this.tabPageAddSale.Controls.Add(this.dataGridViewCartItem);
            this.tabPageAddSale.Controls.Add(this.btnRemoveFromCart);
            this.tabPageAddSale.Controls.Add(this.btnCheckOut);
            this.tabPageAddSale.Controls.Add(this.labelSubTotalAmount);
            this.tabPageAddSale.Controls.Add(this.labelSubtotal);
            this.tabPageAddSale.Controls.Add(this.btnAddToCart);
            this.tabPageAddSale.Controls.Add(this.textQuantity);
            this.tabPageAddSale.Controls.Add(this.labelQuantity);
            this.tabPageAddSale.Controls.Add(this.pictureProductPreview);
            this.tabPageAddSale.Controls.Add(this.textSearchProduct);
            this.tabPageAddSale.Controls.Add(this.dataGridViewProduct);
            this.tabPageAddSale.Controls.Add(this.btnSearchProduct);
            this.tabPageAddSale.Controls.Add(this.materialDivider3);
            this.tabPageAddSale.Controls.Add(this.materialDivider2);
            this.tabPageAddSale.Controls.Add(this.materialDivider1);
            this.tabPageAddSale.Controls.Add(this.tabSAddSale);
            this.tabPageAddSale.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddSale.Name = "tabPageAddSale";
            this.tabPageAddSale.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddSale.Size = new System.Drawing.Size(934, 441);
            this.tabPageAddSale.TabIndex = 0;
            this.tabPageAddSale.Text = "Add Sale";
            // 
            // pictureProductPreview
            // 
            this.pictureProductPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureProductPreview.Location = new System.Drawing.Point(434, 66);
            this.pictureProductPreview.Margin = new System.Windows.Forms.Padding(15);
            this.pictureProductPreview.MaximumSize = new System.Drawing.Size(156, 156);
            this.pictureProductPreview.MinimumSize = new System.Drawing.Size(96, 96);
            this.pictureProductPreview.Name = "pictureProductPreview";
            this.pictureProductPreview.Size = new System.Drawing.Size(155, 155);
            this.pictureProductPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProductPreview.TabIndex = 0;
            this.pictureProductPreview.TabStop = false;
            // 
            // textSearchProduct
            // 
            this.textSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearchProduct.Depth = 0;
            this.textSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchProduct.Hint = "Product Name";
            this.textSearchProduct.Location = new System.Drawing.Point(152, 86);
            this.textSearchProduct.MaxLength = 32767;
            this.textSearchProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.textSearchProduct.Name = "textSearchProduct";
            this.textSearchProduct.PasswordChar = '\0';
            this.textSearchProduct.SelectedText = "";
            this.textSearchProduct.SelectionLength = 0;
            this.textSearchProduct.SelectionStart = 0;
            this.textSearchProduct.Size = new System.Drawing.Size(185, 23);
            this.textSearchProduct.TabIndex = 27;
            this.textSearchProduct.TabStop = false;
            this.textSearchProduct.UseSystemPasswordChar = false;
            this.textSearchProduct.Click += new System.EventHandler(this.textSearchProduct_Click);
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewProduct.Location = new System.Drawing.Point(16, 125);
            this.dataGridViewProduct.MultiSelect = false;
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            this.dataGridViewProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewProduct.RowTemplate.Height = 32;
            this.dataGridViewProduct.Size = new System.Drawing.Size(400, 300);
            this.dataGridViewProduct.TabIndex = 26;
            this.dataGridViewProduct.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewProduct_DataBindingComplete);
            this.dataGridViewProduct.Click += new System.EventHandler(this.dataGridViewProduct_Click);
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchProduct.AutoSize = true;
            this.btnSearchProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchProduct.Depth = 0;
            this.btnSearchProduct.Icon = null;
            this.btnSearchProduct.Location = new System.Drawing.Point(343, 73);
            this.btnSearchProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Primary = true;
            this.btnSearchProduct.Size = new System.Drawing.Size(73, 36);
            this.btnSearchProduct.TabIndex = 28;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
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
            // tabSAddSale
            // 
            this.tabSAddSale.BaseTabControl = this.mtcSale;
            this.tabSAddSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabSAddSale.Depth = 0;
            this.tabSAddSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSAddSale.Location = new System.Drawing.Point(3, 3);
            this.tabSAddSale.Margin = new System.Windows.Forms.Padding(0);
            this.tabSAddSale.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSAddSale.Name = "tabSAddSale";
            this.tabSAddSale.Size = new System.Drawing.Size(928, 48);
            this.tabSAddSale.TabIndex = 1;
            this.tabSAddSale.Text = "materialTabSelector2";
            // 
            // tabPageManageSale
            // 
            this.tabPageManageSale.BackColor = System.Drawing.Color.White;
            this.tabPageManageSale.Controls.Add(this.btnUpdateSale);
            this.tabPageManageSale.Controls.Add(this.btnDeleteSale);
            this.tabPageManageSale.Controls.Add(this.textSearchSale);
            this.tabPageManageSale.Controls.Add(this.btnSearchSale);
            this.tabPageManageSale.Controls.Add(this.dataGridViewSale);
            this.tabPageManageSale.Controls.Add(this.materialDivider7);
            this.tabPageManageSale.Controls.Add(this.materialDivider8);
            this.tabPageManageSale.Controls.Add(this.materialDivider9);
            this.tabPageManageSale.Controls.Add(this.tabSManageSale);
            this.tabPageManageSale.Location = new System.Drawing.Point(4, 22);
            this.tabPageManageSale.Name = "tabPageManageSale";
            this.tabPageManageSale.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManageSale.Size = new System.Drawing.Size(934, 441);
            this.tabPageManageSale.TabIndex = 2;
            this.tabPageManageSale.Text = "Manage Sales";
            // 
            // btnUpdateSale
            // 
            this.btnUpdateSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateSale.AutoSize = true;
            this.btnUpdateSale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateSale.Depth = 0;
            this.btnUpdateSale.Icon = null;
            this.btnUpdateSale.Location = new System.Drawing.Point(328, 69);
            this.btnUpdateSale.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateSale.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateSale.Name = "btnUpdateSale";
            this.btnUpdateSale.Primary = false;
            this.btnUpdateSale.Size = new System.Drawing.Size(73, 36);
            this.btnUpdateSale.TabIndex = 15;
            this.btnUpdateSale.Text = "Update";
            this.btnUpdateSale.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSale
            // 
            this.btnDeleteSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSale.AutoSize = true;
            this.btnDeleteSale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteSale.Depth = 0;
            this.btnDeleteSale.Icon = null;
            this.btnDeleteSale.Location = new System.Drawing.Point(409, 69);
            this.btnDeleteSale.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteSale.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteSale.Name = "btnDeleteSale";
            this.btnDeleteSale.Primary = false;
            this.btnDeleteSale.Size = new System.Drawing.Size(69, 36);
            this.btnDeleteSale.TabIndex = 11;
            this.btnDeleteSale.Text = "Delete";
            this.btnDeleteSale.UseVisualStyleBackColor = true;
            // 
            // textSearchSale
            // 
            this.textSearchSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearchSale.Depth = 0;
            this.textSearchSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchSale.Hint = "Sale ID";
            this.textSearchSale.Location = new System.Drawing.Point(530, 82);
            this.textSearchSale.MaxLength = 32767;
            this.textSearchSale.MouseState = MaterialSkin.MouseState.HOVER;
            this.textSearchSale.Name = "textSearchSale";
            this.textSearchSale.PasswordChar = '\0';
            this.textSearchSale.SelectedText = "";
            this.textSearchSale.SelectionLength = 0;
            this.textSearchSale.SelectionStart = 0;
            this.textSearchSale.Size = new System.Drawing.Size(185, 23);
            this.textSearchSale.TabIndex = 10;
            this.textSearchSale.TabStop = false;
            this.textSearchSale.UseSystemPasswordChar = false;
            // 
            // btnSearchSale
            // 
            this.btnSearchSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchSale.AutoSize = true;
            this.btnSearchSale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchSale.Depth = 0;
            this.btnSearchSale.Icon = null;
            this.btnSearchSale.Location = new System.Drawing.Point(721, 69);
            this.btnSearchSale.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearchSale.Name = "btnSearchSale";
            this.btnSearchSale.Primary = true;
            this.btnSearchSale.Size = new System.Drawing.Size(73, 36);
            this.btnSearchSale.TabIndex = 9;
            this.btnSearchSale.Text = "Search";
            this.btnSearchSale.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSale
            // 
            this.dataGridViewSale.AllowUserToAddRows = false;
            this.dataGridViewSale.AllowUserToDeleteRows = false;
            this.dataGridViewSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSale.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSale.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewSale.Location = new System.Drawing.Point(195, 136);
            this.dataGridViewSale.MultiSelect = false;
            this.dataGridViewSale.Name = "dataGridViewSale";
            this.dataGridViewSale.ReadOnly = true;
            this.dataGridViewSale.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewSale.RowTemplate.Height = 32;
            this.dataGridViewSale.Size = new System.Drawing.Size(720, 286);
            this.dataGridViewSale.TabIndex = 8;
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
            // tabSManageSale
            // 
            this.tabSManageSale.BaseTabControl = this.mtcSale;
            this.tabSManageSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabSManageSale.Depth = 0;
            this.tabSManageSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSManageSale.Location = new System.Drawing.Point(3, 3);
            this.tabSManageSale.Margin = new System.Windows.Forms.Padding(0);
            this.tabSManageSale.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSManageSale.Name = "tabSManageSale";
            this.tabSManageSale.Size = new System.Drawing.Size(928, 48);
            this.tabSManageSale.TabIndex = 2;
            this.tabSManageSale.Text = "materialTabSelector2";
            // 
            // textQuantity
            // 
            this.textQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textQuantity.Depth = 0;
            this.textQuantity.Hint = "1";
            this.textQuantity.Location = new System.Drawing.Point(439, 264);
            this.textQuantity.MaxLength = 10;
            this.textQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.PasswordChar = '\0';
            this.textQuantity.SelectedText = "";
            this.textQuantity.SelectionLength = 0;
            this.textQuantity.SelectionStart = 0;
            this.textQuantity.Size = new System.Drawing.Size(108, 23);
            this.textQuantity.TabIndex = 30;
            this.textQuantity.TabStop = false;
            this.textQuantity.UseSystemPasswordChar = false;
            // 
            // labelQuantity
            // 
            this.labelQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Depth = 0;
            this.labelQuantity.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelQuantity.Location = new System.Drawing.Point(435, 239);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(3);
            this.labelQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(74, 19);
            this.labelQuantity.TabIndex = 29;
            this.labelQuantity.Text = "Quantity *";
            this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToCart.AutoSize = true;
            this.btnAddToCart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddToCart.Depth = 0;
            this.btnAddToCart.Icon = null;
            this.btnAddToCart.Location = new System.Drawing.Point(434, 293);
            this.btnAddToCart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Primary = true;
            this.btnAddToCart.Size = new System.Drawing.Size(108, 36);
            this.btnAddToCart.TabIndex = 35;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Depth = 0;
            this.labelSubtotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSubtotal.Location = new System.Drawing.Point(435, 339);
            this.labelSubtotal.Margin = new System.Windows.Forms.Padding(3);
            this.labelSubtotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(69, 19);
            this.labelSubtotal.TabIndex = 37;
            this.labelSubtotal.Text = "Subtotal:";
            this.labelSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSubTotalAmount
            // 
            this.labelSubTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubTotalAmount.AutoSize = true;
            this.labelSubTotalAmount.Depth = 0;
            this.labelSubTotalAmount.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelSubTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSubTotalAmount.Location = new System.Drawing.Point(552, 339);
            this.labelSubTotalAmount.Margin = new System.Windows.Forms.Padding(3);
            this.labelSubTotalAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSubTotalAmount.Name = "labelSubTotalAmount";
            this.labelSubTotalAmount.Size = new System.Drawing.Size(37, 19);
            this.labelSubTotalAmount.TabIndex = 38;
            this.labelSubTotalAmount.Text = "0.00";
            this.labelSubTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckOut.AutoSize = true;
            this.btnCheckOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckOut.Depth = 0;
            this.btnCheckOut.Icon = null;
            this.btnCheckOut.Location = new System.Drawing.Point(439, 364);
            this.btnCheckOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Primary = true;
            this.btnCheckOut.Size = new System.Drawing.Size(95, 36);
            this.btnCheckOut.TabIndex = 39;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveFromCart.AutoSize = true;
            this.btnRemoveFromCart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveFromCart.Depth = 0;
            this.btnRemoveFromCart.Icon = null;
            this.btnRemoveFromCart.Location = new System.Drawing.Point(760, 70);
            this.btnRemoveFromCart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemoveFromCart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Primary = false;
            this.btnRemoveFromCart.Size = new System.Drawing.Size(155, 36);
            this.btnRemoveFromCart.TabIndex = 40;
            this.btnRemoveFromCart.Text = "Remove From Cart";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // dataGridViewCartItem
            // 
            this.dataGridViewCartItem.AllowUserToAddRows = false;
            this.dataGridViewCartItem.AllowUserToDeleteRows = false;
            this.dataGridViewCartItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCartItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCartItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCartItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewCartItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCartItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCartItem.Location = new System.Drawing.Point(618, 125);
            this.dataGridViewCartItem.MaximumSize = new System.Drawing.Size(300, 600);
            this.dataGridViewCartItem.MultiSelect = false;
            this.dataGridViewCartItem.Name = "dataGridViewCartItem";
            this.dataGridViewCartItem.ReadOnly = true;
            this.dataGridViewCartItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewCartItem.RowTemplate.Height = 32;
            this.dataGridViewCartItem.Size = new System.Drawing.Size(300, 300);
            this.dataGridViewCartItem.TabIndex = 41;
            // 
            // PointOfSalePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.mtcSale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "PointOfSalePage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Sales";
            this.Load += new System.EventHandler(this.PointOfSalePage_Load);
            this.mtcSale.ResumeLayout(false);
            this.tabPageAddSale.ResumeLayout(false);
            this.tabPageAddSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProductPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.tabPageManageSale.ResumeLayout(false);
            this.tabPageManageSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mtcSale;
        private System.Windows.Forms.TabPage tabPageAddSale;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialTabSelector tabSAddSale;
        private System.Windows.Forms.TabPage tabPageManageSale;
        private MaterialSkin.Controls.MaterialFlatButton btnUpdateSale;
        private MaterialSkin.Controls.MaterialFlatButton btnDeleteSale;
        private MaterialSkin.Controls.MaterialSingleLineTextField textSearchSale;
        private MaterialSkin.Controls.MaterialRaisedButton btnSearchSale;
        private System.Windows.Forms.DataGridView dataGridViewSale;
        private MaterialSkin.Controls.MaterialDivider materialDivider7;
        private MaterialSkin.Controls.MaterialDivider materialDivider8;
        private MaterialSkin.Controls.MaterialDivider materialDivider9;
        private MaterialSkin.Controls.MaterialTabSelector tabSManageSale;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.PictureBox pictureProductPreview;
        private MaterialSkin.Controls.MaterialSingleLineTextField textSearchProduct;
        private MaterialSkin.Controls.MaterialRaisedButton btnSearchProduct;
        private MaterialSkin.Controls.MaterialSingleLineTextField textQuantity;
        private MaterialSkin.Controls.MaterialLabel labelQuantity;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddToCart;
        private MaterialSkin.Controls.MaterialRaisedButton btnCheckOut;
        private MaterialSkin.Controls.MaterialLabel labelSubTotalAmount;
        private MaterialSkin.Controls.MaterialLabel labelSubtotal;
        private MaterialSkin.Controls.MaterialFlatButton btnRemoveFromCart;
        private System.Windows.Forms.DataGridView dataGridViewCartItem;
    }
}