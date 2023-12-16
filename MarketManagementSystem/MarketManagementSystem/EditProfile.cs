using MarketManagementSystem.Controllers;
using MarketManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagementSystem
{
    public partial class EditProfile : Form
    {

        UserCrud userCrud = new UserCrud();
        Functions functions = new Functions();
        public static int CurrentUserId { get; set; }

        public EditProfile()
        {
            InitializeComponent();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            var selectedUser = userCrud.GetById(CurrentUserId);

            functions.GetRoleListToCb(UserRoleComboBox);


            if (selectedUser != null)
            {
                UserNameTxt.Text = selectedUser.Name;
                UserSurameTxt.Text = selectedUser.Surname;
                UserDescriptionRtb.Text = selectedUser.Description;
                UserEmailTxt.Text = selectedUser.Email;
                UserPasswordTxt.Text = selectedUser.Password;
                UserStatusCb.Checked = selectedUser.IsStatus;
            }
            UserStatusCb.Visible = false;
            UserRoleComboBox.Visible = false;
        }

        private void UpdateUserBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = UserNameTxt.Text;
            user.Surname = UserSurameTxt.Text;
            user.Description = UserDescriptionRtb.Text;
            user.Email = UserEmailTxt.Text;
            user.Password = UserPasswordTxt.Text;
            user.RoleId = Convert.ToInt32(UserRoleComboBox.SelectedValue);
            user.IsStatus = UserStatusCb.Checked;

            string UserImage = "";
            string imagePath = @"C:\Users\yasir\OneDrive\Masaüstü\C# Uygulamaları\MarketManagementSystem\MarketManagementSystem\Images\";
            string defaultImage = "emptyUser.jpg";
            if (UserImg.Image != null)
            {
                string imageName = Guid.NewGuid() + ".jpg";
                UserImg.Image.Save(imagePath + imageName, ImageFormat.Jpeg);
                UserImage = imagePath + imageName;
            }
            else { UserImage = imagePath + defaultImage; }
            user.Image = UserImage;

            if (userCrud.Update(user, user.Id))
            {
                MessageBox.Show("Profile updated successfully");

                UserNameTxt.Clear();
                UserSurameTxt.Clear();
                UserEmailTxt.Clear();
                UserPasswordTxt.Clear();
                UserDescriptionRtb.Clear();
                UserStatusCb.Checked = false;
                UserImg.Image = null;
                this.Close();
            }
            else
            {
                MessageBox.Show("An unexpected error occurred while updating Profile");

            }

        }

        private void UpdateUserBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
