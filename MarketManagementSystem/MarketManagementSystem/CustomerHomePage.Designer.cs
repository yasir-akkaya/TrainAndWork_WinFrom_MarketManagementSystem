namespace MarketManagementSystem
{
    partial class CustomerHomePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MyOrdersBtn = new System.Windows.Forms.Button();
            this.BuyCartBtn = new System.Windows.Forms.Button();
            this.WelcomeTxt = new System.Windows.Forms.Label();
            this.EditUserBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CartPanel = new System.Windows.Forms.Panel();
            this.ProductListPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.MyOrdersBtn);
            this.panel1.Controls.Add(this.BuyCartBtn);
            this.panel1.Controls.Add(this.WelcomeTxt);
            this.panel1.Controls.Add(this.EditUserBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 123);
            this.panel1.TabIndex = 0;
            // 
            // MyOrdersBtn
            // 
            this.MyOrdersBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.MyOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MyOrdersBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MyOrdersBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MyOrdersBtn.Location = new System.Drawing.Point(145, 12);
            this.MyOrdersBtn.Name = "MyOrdersBtn";
            this.MyOrdersBtn.Size = new System.Drawing.Size(136, 35);
            this.MyOrdersBtn.TabIndex = 9;
            this.MyOrdersBtn.Text = "My Orders";
            this.MyOrdersBtn.UseVisualStyleBackColor = false;
            this.MyOrdersBtn.Click += new System.EventHandler(this.MyOrdersBtn_Click);
            // 
            // BuyCartBtn
            // 
            this.BuyCartBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.BuyCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuyCartBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BuyCartBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BuyCartBtn.Location = new System.Drawing.Point(264, 88);
            this.BuyCartBtn.Name = "BuyCartBtn";
            this.BuyCartBtn.Size = new System.Drawing.Size(136, 35);
            this.BuyCartBtn.TabIndex = 8;
            this.BuyCartBtn.Text = "Buy Cart";
            this.BuyCartBtn.UseVisualStyleBackColor = false;
            this.BuyCartBtn.Click += new System.EventHandler(this.BuyCartBtn_Click);
            // 
            // WelcomeTxt
            // 
            this.WelcomeTxt.AutoSize = true;
            this.WelcomeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WelcomeTxt.Location = new System.Drawing.Point(405, 9);
            this.WelcomeTxt.Name = "WelcomeTxt";
            this.WelcomeTxt.Size = new System.Drawing.Size(160, 38);
            this.WelcomeTxt.TabIndex = 7;
            this.WelcomeTxt.Text = "Welcome";
            // 
            // EditUserBtn
            // 
            this.EditUserBtn.BackColor = System.Drawing.Color.Khaki;
            this.EditUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditUserBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditUserBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditUserBtn.Location = new System.Drawing.Point(3, 12);
            this.EditUserBtn.Name = "EditUserBtn";
            this.EditUserBtn.Size = new System.Drawing.Size(136, 35);
            this.EditUserBtn.TabIndex = 6;
            this.EditUserBtn.Text = "Edit Profile";
            this.EditUserBtn.UseVisualStyleBackColor = false;
            this.EditUserBtn.Click += new System.EventHandler(this.EditUserBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-7, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shopping Cart";
            // 
            // CartPanel
            // 
            this.CartPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CartPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CartPanel.Location = new System.Drawing.Point(0, 123);
            this.CartPanel.Name = "CartPanel";
            this.CartPanel.Size = new System.Drawing.Size(264, 480);
            this.CartPanel.TabIndex = 1;
            // 
            // ProductListPanel
            // 
            this.ProductListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductListPanel.Location = new System.Drawing.Point(264, 123);
            this.ProductListPanel.Name = "ProductListPanel";
            this.ProductListPanel.Size = new System.Drawing.Size(1136, 480);
            this.ProductListPanel.TabIndex = 1;
            // 
            // CustomerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1400, 603);
            this.Controls.Add(this.ProductListPanel);
            this.Controls.Add(this.CartPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomerHomePage";
            this.Text = "Welcome!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.CustomerHomePage_Activated);
            this.Load += new System.EventHandler(this.CustomerHomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel CartPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ProductListPanel;
        private System.Windows.Forms.Button EditUserBtn;
        private System.Windows.Forms.Label WelcomeTxt;
        private System.Windows.Forms.Button BuyCartBtn;
        private System.Windows.Forms.Button MyOrdersBtn;
    }
}