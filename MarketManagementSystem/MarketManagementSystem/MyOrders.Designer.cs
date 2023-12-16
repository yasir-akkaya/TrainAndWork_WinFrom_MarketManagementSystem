namespace MarketManagementSystem
{
    partial class MyOrders
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
            this.UserOrdersDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserOrdersDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // UserOrdersDgv
            // 
            this.UserOrdersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserOrdersDgv.Location = new System.Drawing.Point(47, 123);
            this.UserOrdersDgv.Name = "UserOrdersDgv";
            this.UserOrdersDgv.RowHeadersWidth = 51;
            this.UserOrdersDgv.RowTemplate.Height = 24;
            this.UserOrdersDgv.Size = new System.Drawing.Size(418, 315);
            this.UserOrdersDgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Orders";
            // 
            // MyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserOrdersDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MyOrders";
            this.Text = "MyOrders";
            this.Load += new System.EventHandler(this.MyOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserOrdersDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserOrdersDgv;
        private System.Windows.Forms.Label label1;
    }
}