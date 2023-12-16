namespace MarketManagementSystem
{
    partial class AdminHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomePage));
            this.ProductListDgv = new System.Windows.Forms.DataGridView();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.EditProductBtn = new System.Windows.Forms.Button();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.DeleteCustomerBtn = new System.Windows.Forms.Button();
            this.EditCustomerBtn = new System.Windows.Forms.Button();
            this.AddCustomerBtn = new System.Windows.Forms.Button();
            this.UserListLbl = new System.Windows.Forms.Label();
            this.UserDvg = new System.Windows.Forms.DataGridView();
            this.SalesReportsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.RoleDgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CategoryDgv = new System.Windows.Forms.DataGridView();
            this.DeleteCategoryBtn = new System.Windows.Forms.Button();
            this.EditCategoryBtn = new System.Windows.Forms.Button();
            this.AddCategoryBtn = new System.Windows.Forms.Button();
            this.AddRoleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserDvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductListDgv
            // 
            this.ProductListDgv.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ProductListDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductListDgv.GridColor = System.Drawing.SystemColors.Control;
            this.ProductListDgv.Location = new System.Drawing.Point(5, 65);
            this.ProductListDgv.Name = "ProductListDgv";
            this.ProductListDgv.RowHeadersWidth = 51;
            this.ProductListDgv.RowTemplate.Height = 24;
            this.ProductListDgv.Size = new System.Drawing.Size(947, 424);
            this.ProductListDgv.TabIndex = 0;
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserNameLbl.Location = new System.Drawing.Point(-1, 23);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(186, 36);
            this.UserNameLbl.TabIndex = 2;
            this.UserNameLbl.Text = "Product List";
            // 
            // EditProductBtn
            // 
            this.EditProductBtn.BackColor = System.Drawing.Color.Gold;
            this.EditProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditProductBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditProductBtn.Location = new System.Drawing.Point(710, 14);
            this.EditProductBtn.Name = "EditProductBtn";
            this.EditProductBtn.Size = new System.Drawing.Size(118, 45);
            this.EditProductBtn.TabIndex = 4;
            this.EditProductBtn.Text = "Edit Product";
            this.EditProductBtn.UseVisualStyleBackColor = false;
            this.EditProductBtn.Click += new System.EventHandler(this.EditProductBtn_Click);
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteProductBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteProductBtn.Location = new System.Drawing.Point(834, 14);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(118, 45);
            this.DeleteProductBtn.TabIndex = 5;
            this.DeleteProductBtn.Text = "Delete Product";
            this.DeleteProductBtn.UseVisualStyleBackColor = false;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // DeleteCustomerBtn
            // 
            this.DeleteCustomerBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteCustomerBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteCustomerBtn.Location = new System.Drawing.Point(1794, 14);
            this.DeleteCustomerBtn.Name = "DeleteCustomerBtn";
            this.DeleteCustomerBtn.Size = new System.Drawing.Size(118, 45);
            this.DeleteCustomerBtn.TabIndex = 10;
            this.DeleteCustomerBtn.Text = "Delete Customer";
            this.DeleteCustomerBtn.UseVisualStyleBackColor = false;
            this.DeleteCustomerBtn.Click += new System.EventHandler(this.DeleteCustomerBtn_Click);
            // 
            // EditCustomerBtn
            // 
            this.EditCustomerBtn.BackColor = System.Drawing.Color.Gold;
            this.EditCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditCustomerBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditCustomerBtn.Location = new System.Drawing.Point(1670, 14);
            this.EditCustomerBtn.Name = "EditCustomerBtn";
            this.EditCustomerBtn.Size = new System.Drawing.Size(118, 45);
            this.EditCustomerBtn.TabIndex = 9;
            this.EditCustomerBtn.Text = "Edit Customer";
            this.EditCustomerBtn.UseVisualStyleBackColor = false;
            this.EditCustomerBtn.Click += new System.EventHandler(this.EditCustomerBtn_Click);
            // 
            // AddCustomerBtn
            // 
            this.AddCustomerBtn.BackColor = System.Drawing.Color.Green;
            this.AddCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddCustomerBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddCustomerBtn.Location = new System.Drawing.Point(1546, 14);
            this.AddCustomerBtn.Name = "AddCustomerBtn";
            this.AddCustomerBtn.Size = new System.Drawing.Size(118, 45);
            this.AddCustomerBtn.TabIndex = 8;
            this.AddCustomerBtn.Text = "Add Customer";
            this.AddCustomerBtn.UseVisualStyleBackColor = false;
            this.AddCustomerBtn.Click += new System.EventHandler(this.AddCustomerBtn_Click);
            // 
            // UserListLbl
            // 
            this.UserListLbl.AutoSize = true;
            this.UserListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserListLbl.Location = new System.Drawing.Point(1006, 23);
            this.UserListLbl.Name = "UserListLbl";
            this.UserListLbl.Size = new System.Drawing.Size(210, 36);
            this.UserListLbl.TabIndex = 7;
            this.UserListLbl.Text = "Customer List";
            // 
            // UserDvg
            // 
            this.UserDvg.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UserDvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDvg.GridColor = System.Drawing.SystemColors.Control;
            this.UserDvg.Location = new System.Drawing.Point(1012, 65);
            this.UserDvg.Name = "UserDvg";
            this.UserDvg.RowHeadersWidth = 51;
            this.UserDvg.RowTemplate.Height = 24;
            this.UserDvg.Size = new System.Drawing.Size(900, 424);
            this.UserDvg.TabIndex = 6;
            // 
            // SalesReportsBtn
            // 
            this.SalesReportsBtn.BackColor = System.Drawing.Color.DarkRed;
            this.SalesReportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SalesReportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SalesReportsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.SalesReportsBtn.Location = new System.Drawing.Point(5, 851);
            this.SalesReportsBtn.Name = "SalesReportsBtn";
            this.SalesReportsBtn.Size = new System.Drawing.Size(347, 48);
            this.SalesReportsBtn.TabIndex = 11;
            this.SalesReportsBtn.Text = "Sales Reports";
            this.SalesReportsBtn.UseVisualStyleBackColor = false;
            this.SalesReportsBtn.Click += new System.EventHandler(this.SalesReportsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(755, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "*Double click to see details\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1715, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "*Double click to see details\r\n";
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.BackColor = System.Drawing.Color.Green;
            this.AddProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddProductBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddProductBtn.Location = new System.Drawing.Point(586, 14);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(118, 45);
            this.AddProductBtn.TabIndex = 3;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = false;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // RoleDgv
            // 
            this.RoleDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoleDgv.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RoleDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoleDgv.Location = new System.Drawing.Point(5, 551);
            this.RoleDgv.Name = "RoleDgv";
            this.RoleDgv.RowHeadersWidth = 51;
            this.RoleDgv.Size = new System.Drawing.Size(947, 223);
            this.RoleDgv.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(-1, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 36);
            this.label3.TabIndex = 20;
            this.label3.Text = "Roles List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1006, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 36);
            this.label4.TabIndex = 22;
            this.label4.Text = "Category List";
            // 
            // CategoryDgv
            // 
            this.CategoryDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryDgv.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CategoryDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryDgv.Location = new System.Drawing.Point(1012, 551);
            this.CategoryDgv.Name = "CategoryDgv";
            this.CategoryDgv.RowHeadersWidth = 51;
            this.CategoryDgv.Size = new System.Drawing.Size(900, 223);
            this.CategoryDgv.TabIndex = 21;
            // 
            // DeleteCategoryBtn
            // 
            this.DeleteCategoryBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteCategoryBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteCategoryBtn.Location = new System.Drawing.Point(1260, 780);
            this.DeleteCategoryBtn.Name = "DeleteCategoryBtn";
            this.DeleteCategoryBtn.Size = new System.Drawing.Size(118, 45);
            this.DeleteCategoryBtn.TabIndex = 25;
            this.DeleteCategoryBtn.Text = "Delete Category";
            this.DeleteCategoryBtn.UseVisualStyleBackColor = false;
            this.DeleteCategoryBtn.Click += new System.EventHandler(this.DeleteCategoryBtn_Click);
            // 
            // EditCategoryBtn
            // 
            this.EditCategoryBtn.BackColor = System.Drawing.Color.Gold;
            this.EditCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditCategoryBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditCategoryBtn.Location = new System.Drawing.Point(1136, 780);
            this.EditCategoryBtn.Name = "EditCategoryBtn";
            this.EditCategoryBtn.Size = new System.Drawing.Size(118, 45);
            this.EditCategoryBtn.TabIndex = 24;
            this.EditCategoryBtn.Text = "Edit Category";
            this.EditCategoryBtn.UseVisualStyleBackColor = false;
            this.EditCategoryBtn.Click += new System.EventHandler(this.EditCategoryBtn_Click);
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.BackColor = System.Drawing.Color.Green;
            this.AddCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddCategoryBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddCategoryBtn.Location = new System.Drawing.Point(1012, 780);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Size = new System.Drawing.Size(118, 45);
            this.AddCategoryBtn.TabIndex = 23;
            this.AddCategoryBtn.Text = "Add Category";
            this.AddCategoryBtn.UseVisualStyleBackColor = false;
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            // 
            // AddRoleBtn
            // 
            this.AddRoleBtn.BackColor = System.Drawing.Color.Green;
            this.AddRoleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddRoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddRoleBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddRoleBtn.Location = new System.Drawing.Point(5, 780);
            this.AddRoleBtn.Name = "AddRoleBtn";
            this.AddRoleBtn.Size = new System.Drawing.Size(118, 45);
            this.AddRoleBtn.TabIndex = 26;
            this.AddRoleBtn.Text = "Add Role";
            this.AddRoleBtn.UseVisualStyleBackColor = false;
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.AddRoleBtn);
            this.Controls.Add(this.DeleteCategoryBtn);
            this.Controls.Add(this.EditCategoryBtn);
            this.Controls.Add(this.AddCategoryBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CategoryDgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RoleDgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalesReportsBtn);
            this.Controls.Add(this.DeleteCustomerBtn);
            this.Controls.Add(this.EditCustomerBtn);
            this.Controls.Add(this.AddCustomerBtn);
            this.Controls.Add(this.UserListLbl);
            this.Controls.Add(this.UserDvg);
            this.Controls.Add(this.DeleteProductBtn);
            this.Controls.Add(this.EditProductBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.UserNameLbl);
            this.Controls.Add(this.ProductListDgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminHomePage";
            this.Text = "Administor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.AdminHomePage_Activated);
            this.Load += new System.EventHandler(this.AdminHomePage_Load);
            this.Shown += new System.EventHandler(this.AdminHomePage_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserDvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductListDgv;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.Button EditProductBtn;
        private System.Windows.Forms.Button DeleteProductBtn;
        private System.Windows.Forms.Button DeleteCustomerBtn;
        private System.Windows.Forms.Button EditCustomerBtn;
        private System.Windows.Forms.Button AddCustomerBtn;
        private System.Windows.Forms.Label UserListLbl;
        private System.Windows.Forms.DataGridView UserDvg;
        private System.Windows.Forms.Button SalesReportsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.DataGridView RoleDgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView CategoryDgv;
        private System.Windows.Forms.Button DeleteCategoryBtn;
        private System.Windows.Forms.Button EditCategoryBtn;
        private System.Windows.Forms.Button AddCategoryBtn;
        private System.Windows.Forms.Button AddRoleBtn;
    }
}