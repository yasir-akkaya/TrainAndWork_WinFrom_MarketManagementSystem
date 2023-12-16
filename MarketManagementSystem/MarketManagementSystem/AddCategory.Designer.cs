namespace MarketManagementSystem
{
    partial class AddCategory
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
            this.AddProductGb = new System.Windows.Forms.GroupBox();
            this.CategoryDescriptionRtb = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCategoryMessage = new System.Windows.Forms.Label();
            this.AddCategoryBtn = new System.Windows.Forms.Button();
            this.CategoryStatusCb = new System.Windows.Forms.CheckBox();
            this.CatgeoryImageBtn = new System.Windows.Forms.Button();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.CategoryNameTxt = new System.Windows.Forms.TextBox();
            this.CategoryImg = new System.Windows.Forms.PictureBox();
            this.AddProductGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryImg)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductGb
            // 
            this.AddProductGb.Controls.Add(this.CategoryDescriptionRtb);
            this.AddProductGb.Controls.Add(this.label1);
            this.AddProductGb.Controls.Add(this.AddCategoryMessage);
            this.AddProductGb.Controls.Add(this.AddCategoryBtn);
            this.AddProductGb.Controls.Add(this.CategoryStatusCb);
            this.AddProductGb.Controls.Add(this.CategoryImg);
            this.AddProductGb.Controls.Add(this.CatgeoryImageBtn);
            this.AddProductGb.Controls.Add(this.UserNameLbl);
            this.AddProductGb.Controls.Add(this.CategoryNameTxt);
            this.AddProductGb.Location = new System.Drawing.Point(12, 12);
            this.AddProductGb.Name = "AddProductGb";
            this.AddProductGb.Size = new System.Drawing.Size(488, 387);
            this.AddProductGb.TabIndex = 5;
            this.AddProductGb.TabStop = false;
            this.AddProductGb.Text = "Add Categor";
            // 
            // CategoryDescriptionRtb
            // 
            this.CategoryDescriptionRtb.Location = new System.Drawing.Point(17, 95);
            this.CategoryDescriptionRtb.Name = "CategoryDescriptionRtb";
            this.CategoryDescriptionRtb.Size = new System.Drawing.Size(163, 145);
            this.CategoryDescriptionRtb.TabIndex = 17;
            this.CategoryDescriptionRtb.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Description";
            // 
            // AddCategoryMessage
            // 
            this.AddCategoryMessage.AutoSize = true;
            this.AddCategoryMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddCategoryMessage.Location = new System.Drawing.Point(143, 353);
            this.AddCategoryMessage.Name = "AddCategoryMessage";
            this.AddCategoryMessage.Size = new System.Drawing.Size(64, 16);
            this.AddCategoryMessage.TabIndex = 4;
            this.AddCategoryMessage.Text = "Message";
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.BackColor = System.Drawing.Color.Green;
            this.AddCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCategoryBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddCategoryBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddCategoryBtn.Location = new System.Drawing.Point(146, 299);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Size = new System.Drawing.Size(178, 51);
            this.AddCategoryBtn.TabIndex = 5;
            this.AddCategoryBtn.Text = "Add Category";
            this.AddCategoryBtn.UseVisualStyleBackColor = false;
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            // 
            // CategoryStatusCb
            // 
            this.CategoryStatusCb.AutoSize = true;
            this.CategoryStatusCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CategoryStatusCb.Location = new System.Drawing.Point(196, 246);
            this.CategoryStatusCb.Name = "CategoryStatusCb";
            this.CategoryStatusCb.Size = new System.Drawing.Size(72, 20);
            this.CategoryStatusCb.TabIndex = 3;
            this.CategoryStatusCb.Text = "Status";
            this.CategoryStatusCb.UseVisualStyleBackColor = true;
            // 
            // CatgeoryImageBtn
            // 
            this.CatgeoryImageBtn.BackColor = System.Drawing.Color.Cornsilk;
            this.CatgeoryImageBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CatgeoryImageBtn.Location = new System.Drawing.Point(286, 208);
            this.CatgeoryImageBtn.Name = "CatgeoryImageBtn";
            this.CatgeoryImageBtn.Size = new System.Drawing.Size(178, 32);
            this.CatgeoryImageBtn.TabIndex = 5;
            this.CatgeoryImageBtn.Text = "Select Image";
            this.CatgeoryImageBtn.UseVisualStyleBackColor = false;
            this.CatgeoryImageBtn.Click += new System.EventHandler(this.CatgeoryImageBtn_Click);
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserNameLbl.Location = new System.Drawing.Point(14, 19);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(48, 16);
            this.UserNameLbl.TabIndex = 6;
            this.UserNameLbl.Text = "Name";
            // 
            // CategoryNameTxt
            // 
            this.CategoryNameTxt.Location = new System.Drawing.Point(17, 38);
            this.CategoryNameTxt.Name = "CategoryNameTxt";
            this.CategoryNameTxt.Size = new System.Drawing.Size(163, 22);
            this.CategoryNameTxt.TabIndex = 7;
            // 
            // CategoryImg
            // 
            this.CategoryImg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CategoryImg.Location = new System.Drawing.Point(286, 38);
            this.CategoryImg.Name = "CategoryImg";
            this.CategoryImg.Size = new System.Drawing.Size(178, 164);
            this.CategoryImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CategoryImg.TabIndex = 4;
            this.CategoryImg.TabStop = false;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 407);
            this.Controls.Add(this.AddProductGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddCategory";
            this.Text = "Add Category";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            this.AddProductGb.ResumeLayout(false);
            this.AddProductGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddProductGb;
        private System.Windows.Forms.RichTextBox CategoryDescriptionRtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AddCategoryMessage;
        private System.Windows.Forms.Button AddCategoryBtn;
        private System.Windows.Forms.CheckBox CategoryStatusCb;
        private System.Windows.Forms.PictureBox CategoryImg;
        private System.Windows.Forms.Button CatgeoryImageBtn;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.TextBox CategoryNameTxt;
    }
}