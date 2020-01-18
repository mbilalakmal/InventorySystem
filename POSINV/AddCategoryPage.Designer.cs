namespace POSINV
{
    partial class AddCategoryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryPage));
            this.btnAddCategory = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelName = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCategory.AutoSize = true;
            this.btnAddCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCategory.Depth = 0;
            this.btnAddCategory.Icon = null;
            this.btnAddCategory.Location = new System.Drawing.Point(19, 146);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Padding = new System.Windows.Forms.Padding(10);
            this.btnAddCategory.Primary = true;
            this.btnAddCategory.Size = new System.Drawing.Size(128, 36);
            this.btnAddCategory.TabIndex = 8;
            this.btnAddCategory.Text = "Save Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
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
            this.textName.TabIndex = 7;
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
            this.labelName.Size = new System.Drawing.Size(123, 19);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Category Name *";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddCategoryPage
            // 
            this.AcceptButton = this.btnAddCategory;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 192);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(240, 240);
            this.MinimumSize = new System.Drawing.Size(192, 192);
            this.Name = "AddCategoryPage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnAddCategory;
        private MaterialSkin.Controls.MaterialSingleLineTextField textName;
        private MaterialSkin.Controls.MaterialLabel labelName;
    }
}