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
    public partial class AddUserForm : Form
    {
        UserCrud userCrud = new UserCrud();
        Functions functions=new Functions();
        RoleCrud roleCrud= new RoleCrud();  
        public AddUserForm()
        {
            InitializeComponent();
        }

        public void AddUserBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = UserNameTxt.Text;
            user.Surname = UserSurameTxt.Text;
            user.Email = UserEmailTxt.Text;
            user.Password = UserPasswordTxt.Text;
            user.IsStatus = UserStatusCb.Checked;
            user.Description = UserDescriptionRtb.Text;
            user.RoleId = Convert.ToInt32(UserRoleComboBox.SelectedValue);
            
            


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


            AddUserMessage.Text = userCrud.Add(user) ? "User added successfully" : "An unexpected error occurred while adding user";
            UserNameTxt.Clear();
            UserSurameTxt.Clear();
            UserEmailTxt.Clear();
            UserPasswordTxt.Clear();
            UserDescriptionRtb.Clear();
            UserStatusCb.Checked = false;
            UserImg.Image = null;

        }

        private void UserImageBtn_Click(object sender, EventArgs e)
        {
            functions.UploadPictureBoxImg(UserImg);
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

            functions.GetRoleListToCb(UserRoleComboBox);
            AddUserMessage.Visible = false;
        }
    }
}
