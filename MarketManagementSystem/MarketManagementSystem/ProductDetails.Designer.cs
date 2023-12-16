namespace MarketManagementSystem
{
    partial class ProductDetails
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
            this.ProductNameDetailTxt = new System.Windows.Forms.Label();
            this.ProductDetailImgPb = new System.Windows.Forms.PictureBox();
            this.PriceTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddToCartBtn = new System.Windows.Forms.Button();
            this.ProductDescRtb = new System.Windows.Forms.RichTextBox();
            this.StockTxt = new System.Windows.Forms.Label();
            this.QuantityNud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDetailImgPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNud)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductNameDetailTxt
            // 
            this.ProductNameDetailTxt.AutoSize = true;
            this.ProductNameDetailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductNameDetailTxt.Location = new System.Drawing.Point(12, 9);
            this.ProductNameDetailTxt.Name = "ProductNameDetailTxt";
            this.ProductNameDetailTxt.Size = new System.Drawing.Size(137, 38);
            this.ProductNameDetailTxt.TabIndex = 8;
            this.ProductNameDetailTxt.Text = "Product";
            // 
            // ProductDetailImgPb
            // 
            this.ProductDetailImgPb.Location = new System.Drawing.Point(12, 50);
            this.ProductDetailImgPb.Name = "ProductDetailImgPb";
            this.ProductDetailImgPb.Size = new System.Drawing.Size(308, 306);
            this.ProductDetailImgPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductDetailImgPb.TabIndex = 9;
            this.ProductDetailImgPb.TabStop = false;
            // 
            // PriceTxt
            // 
            this.PriceTxt.AutoSize = true;
            this.PriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PriceTxt.Location = new System.Drawing.Point(359, 240);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(65, 20);
            this.PriceTxt.TabIndex = 12;
            this.PriceTxt.Text = "Price: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(359, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Description:";
            // 
            // AddToCartBtn
            // 
            this.AddToCartBtn.BackColor = System.Drawing.Color.Green;
            this.AddToCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddToCartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddToCartBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddToCartBtn.Location = new System.Drawing.Point(399, 281);
            this.AddToCartBtn.Name = "AddToCartBtn";
            this.AddToCartBtn.Size = new System.Drawing.Size(270, 57);
            this.AddToCartBtn.TabIndex = 13;
            this.AddToCartBtn.Text = "Add To Cart";
            this.AddToCartBtn.UseVisualStyleBackColor = false;
            this.AddToCartBtn.Click += new System.EventHandler(this.AddToCartBtn_Click);
            // 
            // ProductDescRtb
            // 
            this.ProductDescRtb.Location = new System.Drawing.Point(363, 50);
            this.ProductDescRtb.Name = "ProductDescRtb";
            this.ProductDescRtb.Size = new System.Drawing.Size(306, 167);
            this.ProductDescRtb.TabIndex = 14;
            this.ProductDescRtb.Text = "";
            // 
            // StockTxt
            // 
            this.StockTxt.AutoSize = true;
            this.StockTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StockTxt.Location = new System.Drawing.Point(359, 220);
            this.StockTxt.Name = "StockTxt";
            this.StockTxt.Size = new System.Drawing.Size(68, 20);
            this.StockTxt.TabIndex = 15;
            this.StockTxt.Text = "Stock: ";
            // 
            // QuantityNud
            // 
            this.QuantityNud.Location = new System.Drawing.Point(544, 345);
            this.QuantityNud.Name = "QuantityNud";
            this.QuantityNud.Size = new System.Drawing.Size(106, 22);
            this.QuantityNud.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(427, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quantity:";
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(699, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuantityNud);
            this.Controls.Add(this.StockTxt);
            this.Controls.Add(this.ProductDescRtb);
            this.Controls.Add(this.AddToCartBtn);
            this.Controls.Add(this.PriceTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductDetailImgPb);
            this.Controls.Add(this.ProductNameDetailTxt);
            this.Name = "ProductDetails";
            this.Text = "ProductDetails";
            this.Load += new System.EventHandler(this.ProductDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDetailImgPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductNameDetailTxt;
        private System.Windows.Forms.PictureBox ProductDetailImgPb;
        private System.Windows.Forms.Label PriceTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddToCartBtn;
        private System.Windows.Forms.RichTextBox ProductDescRtb;
        private System.Windows.Forms.Label StockTxt;
        private System.Windows.Forms.NumericUpDown QuantityNud;
        private System.Windows.Forms.Label label1;
    }
}