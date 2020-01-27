namespace POSINV
{
    partial class ReportsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsPage));
            this.labelPeriod = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelFrom = new MaterialSkin.Controls.MaterialLabel();
            this.labelTo = new MaterialSkin.Controls.MaterialLabel();
            this.btnGenerate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Depth = 0;
            this.labelPeriod.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPeriod.Location = new System.Drawing.Point(52, 109);
            this.labelPeriod.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(102, 19);
            this.labelPeriod.TabIndex = 5;
            this.labelPeriod.Text = "Select Period:";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(56, 141);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 9;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(262, 141);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 10;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Depth = 0;
            this.labelFrom.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFrom.Location = new System.Drawing.Point(148, 183);
            this.labelFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(49, 19);
            this.labelFrom.TabIndex = 11;
            this.labelFrom.Text = "FROM";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Depth = 0;
            this.labelTo.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTo.Location = new System.Drawing.Point(354, 183);
            this.labelTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(28, 19);
            this.labelTo.TabIndex = 12;
            this.labelTo.Text = "TO";
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSize = true;
            this.btnGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerate.Depth = 0;
            this.btnGenerate.Icon = null;
            this.btnGenerate.Location = new System.Drawing.Point(56, 243);
            this.btnGenerate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Primary = true;
            this.btnGenerate.Size = new System.Drawing.Size(144, 36);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // ReportsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.labelPeriod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(880, 495);
            this.MinimumSize = new System.Drawing.Size(600, 337);
            this.Name = "ReportsPage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelPeriod;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private MaterialSkin.Controls.MaterialLabel labelFrom;
        private MaterialSkin.Controls.MaterialLabel labelTo;
        private MaterialSkin.Controls.MaterialRaisedButton btnGenerate;
    }
}