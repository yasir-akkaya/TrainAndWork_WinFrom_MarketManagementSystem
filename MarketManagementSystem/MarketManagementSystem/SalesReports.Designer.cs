namespace MarketManagementSystem
{
    partial class SalesReports
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
            this.BackHomeBtn = new System.Windows.Forms.Button();
            this.MonthlySalesBtn = new System.Windows.Forms.Button();
            this.WeeklySalesBtn = new System.Windows.Forms.Button();
            this.DailySalesBtn = new System.Windows.Forms.Button();
            this.SalesListDgv = new System.Windows.Forms.DataGridView();
            this.SalesListLbl = new System.Windows.Forms.Label();
            this.AllListBtn = new System.Windows.Forms.Button();
            this.PopularProductsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalesListDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // BackHomeBtn
            // 
            this.BackHomeBtn.BackColor = System.Drawing.Color.Yellow;
            this.BackHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackHomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackHomeBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackHomeBtn.Location = new System.Drawing.Point(12, 12);
            this.BackHomeBtn.Name = "BackHomeBtn";
            this.BackHomeBtn.Size = new System.Drawing.Size(182, 45);
            this.BackHomeBtn.TabIndex = 4;
            this.BackHomeBtn.Text = "<-- Back To Main Page";
            this.BackHomeBtn.UseVisualStyleBackColor = false;
            this.BackHomeBtn.Click += new System.EventHandler(this.BackHomeBtn_Click);
            // 
            // MonthlySalesBtn
            // 
            this.MonthlySalesBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.MonthlySalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MonthlySalesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MonthlySalesBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MonthlySalesBtn.Location = new System.Drawing.Point(911, 12);
            this.MonthlySalesBtn.Name = "MonthlySalesBtn";
            this.MonthlySalesBtn.Size = new System.Drawing.Size(150, 45);
            this.MonthlySalesBtn.TabIndex = 8;
            this.MonthlySalesBtn.Text = "List Last Month Sales ";
            this.MonthlySalesBtn.UseVisualStyleBackColor = false;
            this.MonthlySalesBtn.Click += new System.EventHandler(this.MonthlySalesBtn_Click);
            // 
            // WeeklySalesBtn
            // 
            this.WeeklySalesBtn.BackColor = System.Drawing.Color.LightGreen;
            this.WeeklySalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WeeklySalesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WeeklySalesBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WeeklySalesBtn.Location = new System.Drawing.Point(755, 12);
            this.WeeklySalesBtn.Name = "WeeklySalesBtn";
            this.WeeklySalesBtn.Size = new System.Drawing.Size(150, 45);
            this.WeeklySalesBtn.TabIndex = 7;
            this.WeeklySalesBtn.Text = "List Last Week Sales ";
            this.WeeklySalesBtn.UseVisualStyleBackColor = false;
            this.WeeklySalesBtn.Click += new System.EventHandler(this.WeeklySalesBtn_Click);
            // 
            // DailySalesBtn
            // 
            this.DailySalesBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.DailySalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DailySalesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DailySalesBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DailySalesBtn.Location = new System.Drawing.Point(599, 12);
            this.DailySalesBtn.Name = "DailySalesBtn";
            this.DailySalesBtn.Size = new System.Drawing.Size(150, 45);
            this.DailySalesBtn.TabIndex = 6;
            this.DailySalesBtn.Text = "List Last 24h Sales";
            this.DailySalesBtn.UseVisualStyleBackColor = false;
            this.DailySalesBtn.Click += new System.EventHandler(this.DailySalesBtn_Click);
            // 
            // SalesListDgv
            // 
            this.SalesListDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesListDgv.Location = new System.Drawing.Point(12, 146);
            this.SalesListDgv.Name = "SalesListDgv";
            this.SalesListDgv.RowHeadersWidth = 51;
            this.SalesListDgv.RowTemplate.Height = 24;
            this.SalesListDgv.Size = new System.Drawing.Size(848, 523);
            this.SalesListDgv.TabIndex = 9;
            // 
            // SalesListLbl
            // 
            this.SalesListLbl.AutoSize = true;
            this.SalesListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SalesListLbl.Location = new System.Drawing.Point(12, 107);
            this.SalesListLbl.Name = "SalesListLbl";
            this.SalesListLbl.Size = new System.Drawing.Size(154, 36);
            this.SalesListLbl.TabIndex = 10;
            this.SalesListLbl.Text = "Sales List";
            // 
            // AllListBtn
            // 
            this.AllListBtn.BackColor = System.Drawing.Color.Green;
            this.AllListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AllListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AllListBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AllListBtn.Location = new System.Drawing.Point(755, 63);
            this.AllListBtn.Name = "AllListBtn";
            this.AllListBtn.Size = new System.Drawing.Size(306, 45);
            this.AllListBtn.TabIndex = 12;
            this.AllListBtn.Text = "List All Sales";
            this.AllListBtn.UseVisualStyleBackColor = false;
            this.AllListBtn.Click += new System.EventHandler(this.AllListBtn_Click);
            // 
            // PopularProductsBtn
            // 
            this.PopularProductsBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.PopularProductsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PopularProductsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PopularProductsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.PopularProductsBtn.Location = new System.Drawing.Point(866, 146);
            this.PopularProductsBtn.Name = "PopularProductsBtn";
            this.PopularProductsBtn.Size = new System.Drawing.Size(195, 45);
            this.PopularProductsBtn.TabIndex = 13;
            this.PopularProductsBtn.Text = "List Popular Products";
            this.PopularProductsBtn.UseVisualStyleBackColor = false;
            this.PopularProductsBtn.Click += new System.EventHandler(this.PopularProductsBtn_Click);
            // 
            // SalesReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 681);
            this.Controls.Add(this.PopularProductsBtn);
            this.Controls.Add(this.AllListBtn);
            this.Controls.Add(this.SalesListLbl);
            this.Controls.Add(this.SalesListDgv);
            this.Controls.Add(this.MonthlySalesBtn);
            this.Controls.Add(this.WeeklySalesBtn);
            this.Controls.Add(this.DailySalesBtn);
            this.Controls.Add(this.BackHomeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SalesReports";
            this.Text = "Sales Reports";
            ((System.ComponentModel.ISupportInitialize)(this.SalesListDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackHomeBtn;
        private System.Windows.Forms.Button MonthlySalesBtn;
        private System.Windows.Forms.Button WeeklySalesBtn;
        private System.Windows.Forms.Button DailySalesBtn;
        private System.Windows.Forms.DataGridView SalesListDgv;
        private System.Windows.Forms.Label SalesListLbl;
        private System.Windows.Forms.Button AllListBtn;
        private System.Windows.Forms.Button PopularProductsBtn;
    }
}