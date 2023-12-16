namespace MarketManagementSystem
{
    partial class EditProfile
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
            this.AddUserGb = new System.Windows.Forms.GroupBox();
            this.UserDescriptionRtb = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserRoleComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateUserBtn = new System.Windows.Forms.Button();
            this.UserEmailLbl = new System.Windows.Forms.Label();
            this.UserEmailTxt = new System.Windows.Forms.TextBox();
            this.UserPasswordLbl = new System.Windows.Forms.Label();
            this.UserPasswordTxt = new System.Windows.Forms.TextBox();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.UserSurameTxt = new System.Windows.Forms.TextBox();
            this.UserStatusCb = new System.Windows.Forms.CheckBox();
            this.UserImg = new System.Windows.Forms.PictureBox();
            this.UserImageBtn = new System.Windows.Forms.Button();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.AddUserGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserImg)).BeginInit();
            this.SuspendLayout();
            // 
            // AddUserGb
            // 
            this.AddUserGb.Controls.Add(this.UserDescriptionRtb);
            this.AddUserGb.Controls.Add(this.label1);
            this.AddUserGb.Controls.Add(this.UserRoleComboBox);
            this.AddUserGb.Controls.Add(this.UpdateUserBtn);
            this.AddUserGb.Controls.Add(this.UserEmailLbl);
            this.AddUserGb.Controls.Add(this.UserEmailTxt);
            this.AddUserGb.Controls.Add(this.UserPasswordLbl);
            this.AddUserGb.Controls.Add(this.UserPasswordTxt);
            this.AddUserGb.Controls.Add(this.SurnameLbl);
            this.AddUserGb.Controls.Add(this.UserSurameTxt);
            this.AddUserGb.Controls.Add(this.UserStatusCb);
            this.AddUserGb.Controls.Add(this.UserImg);
            this.AddUserGb.Controls.Add(this.UserImageBtn);
            this.AddUserGb.Controls.Add(this.UserNameLbl);
            this.AddUserGb.Controls.Add(this.UserNameTxt);
            this.AddUserGb.Location = new System.Drawing.Point(12, 12);
            this.AddUserGb.Name = "AddUserGb";
            this.AddUserGb.Size = new System.Drawing.Size(488, 409);
            this.AddUserGb.TabIndex = 5;
            this.AddUserGb.TabStop = false;
            this.AddUserGb.Text = "Edit Customer";
            // 
            // UserDescriptionRtb
            // 
            this.UserDescriptionRtb.Location = new System.Drawing.Point(17, 243);
            this.UserDescriptionRtb.Name = "UserDescriptionRtb";
            this.UserDescriptionRtb.Size = new System.Drawing.Size(163, 107);
            this.UserDescriptionRtb.TabIndex = 17;
            this.UserDescriptionRtb.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Description";
            // 
            // UserRoleComboBox
            // 
            this.UserRoleComboBox.FormattingEnabled = true;
            this.UserRoleComboBox.Location = new System.Drawing.Point(216, 457);
            this.UserRoleComboBox.Name = "UserRoleComboBox";
            this.UserRoleComboBox.Size = new System.Drawing.Size(163, 24);
            this.UserRoleComboBox.TabIndex = 15;
            // 
            // UpdateUserBtn
            // 
            this.UpdateUserBtn.BackColor = System.Drawing.Color.Green;
            this.UpdateUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateUserBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateUserBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateUserBtn.Location = new System.Drawing.Point(237, 299);
            this.UpdateUserBtn.Name = "UpdateUserBtn";
            this.UpdateUserBtn.Size = new System.Drawing.Size(178, 51);
            this.UpdateUserBtn.TabIndex = 5;
            this.UpdateUserBtn.Text = "Update Profile";
            this.UpdateUserBtn.UseVisualStyleBackColor = false;
            this.UpdateUserBtn.Click += new System.EventHandler(this.UpdateUserBtn_Click_1);
            // 
            // UserEmailLbl
            // 
            this.UserEmailLbl.AutoSize = true;
            this.UserEmailLbl.Location = new System.Drawing.Point(14, 123);
            this.UserEmailLbl.Name = "UserEmailLbl";
            this.UserEmailLbl.Size = new System.Drawing.Size(45, 16);
            this.UserEmailLbl.TabIndex = 12;
            this.UserEmailLbl.Text = "E-mail";
            // 
            // UserEmailTxt
            // 
            this.UserEmailTxt.Location = new System.Drawing.Point(17, 142);
            this.UserEmailTxt.Name = "UserEmailTxt";
            this.UserEmailTxt.Size = new System.Drawing.Size(163, 22);
            this.UserEmailTxt.TabIndex = 13;
            // 
            // UserPasswordLbl
            // 
            this.UserPasswordLbl.AutoSize = true;
            this.UserPasswordLbl.Location = new System.Drawing.Point(14, 180);
            this.UserPasswordLbl.Name = "UserPasswordLbl";
            this.UserPasswordLbl.Size = new System.Drawing.Size(97, 16);
            this.UserPasswordLbl.TabIndex = 10;
            this.UserPasswordLbl.Text = "New Password";
            // 
            // UserPasswordTxt
            // 
            this.UserPasswordTxt.Location = new System.Drawing.Point(17, 199);
            this.UserPasswordTxt.Name = "UserPasswordTxt";
            this.UserPasswordTxt.PasswordChar = '*';
            this.UserPasswordTxt.Size = new System.Drawing.Size(163, 22);
            this.UserPasswordTxt.TabIndex = 11;
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Location = new System.Drawing.Point(14, 69);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(61, 16);
            this.SurnameLbl.TabIndex = 8;
            this.SurnameLbl.Text = "Surname";
            // 
            // UserSurameTxt
            // 
            this.UserSurameTxt.Location = new System.Drawing.Point(17, 88);
            this.UserSurameTxt.Name = "UserSurameTxt";
            this.UserSurameTxt.Size = new System.Drawing.Size(163, 22);
            this.UserSurameTxt.TabIndex = 9;
            // 
            // UserStatusCb
            // 
            this.UserStatusCb.AutoSize = true;
            this.UserStatusCb.Location = new System.Drawing.Point(237, 418);
            this.UserStatusCb.Name = "UserStatusCb";
            this.UserStatusCb.Size = new System.Drawing.Size(66, 20);
            this.UserStatusCb.TabIndex = 3;
            this.UserStatusCb.Text = "Status";
            this.UserStatusCb.UseVisualStyleBackColor = true;
            // 
            // UserImg
            // 
            this.UserImg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UserImg.Location = new System.Drawing.Point(242, 38);
            this.UserImg.Name = "UserImg";
            this.UserImg.Size = new System.Drawing.Size(178, 164);
            this.UserImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserImg.TabIndex = 4;
            this.UserImg.TabStop = false;
            // 
            // UserImageBtn
            // 
            this.UserImageBtn.BackColor = System.Drawing.Color.Cornsilk;
            this.UserImageBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserImageBtn.Location = new System.Drawing.Point(242, 208);
            this.UserImageBtn.Name = "UserImageBtn";
            this.UserImageBtn.Size = new System.Drawing.Size(178, 32);
            this.UserImageBtn.TabIndex = 5;
            this.UserImageBtn.Text = "Select Image";
            this.UserImageBtn.UseVisualStyleBackColor = false;
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Location = new System.Drawing.Point(14, 19);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(44, 16);
            this.UserNameLbl.TabIndex = 6;
            this.UserNameLbl.Text = "Name";
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Location = new System.Drawing.Point(17, 38);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(163, 22);
            this.UserNameTxt.TabIndex = 7;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(518, 443);
            this.Controls.Add(this.AddUserGb);
            this.Name = "EditProfile";
            this.Text = "Edit Profile";
            this.Load += new System.EventHandler(this.EditProfile_Load);
            this.AddUserGb.ResumeLayout(false);
            this.AddUserGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddUserGb;
        private System.Windows.Forms.RichTextBox UserDescriptionRtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateUserBtn;
        private System.Windows.Forms.Label UserEmailLbl;
        private System.Windows.Forms.TextBox UserEmailTxt;
        private System.Windows.Forms.Label UserPasswordLbl;
        private System.Windows.Forms.TextBox UserPasswordTxt;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.TextBox UserSurameTxt;
        private System.Windows.Forms.PictureBox UserImg;
        private System.Windows.Forms.Button UserImageBtn;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.ComboBox UserRoleComboBox;
        private System.Windows.Forms.CheckBox UserStatusCb;
    }
}