using MarketManagementSystem.Controllers;
using MarketManagementSystem.Data;
using MarketManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagementSystem
{
    public partial class LoginForm : Form
    {
        DataContext db = new DataContext();
        UserCrud userCrud = new UserCrud();
        User user = new User();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            user = db.User.FirstOrDefault(u => u.Email == LoginMailTxt.Text && u.Password == LoginPasswordTxt.Text);

            if (user != null)
            {
                int currentUserId = user.Id;
                if (user.RoleId == 2)
                {
                    AdminHomePage AdminHomePage = new AdminHomePage();
                    //AdminHomePage.CurrentUserId = currentUserId;
                    AdminHomePage.Show();
                    this.Hide();
                }
                else
                {
                    CustomerHomePage CustomerHomePage = new CustomerHomePage();
                    CustomerHomePage.CurrentUserId = currentUserId;
                    CustomerHomePage.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid email or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerHomePage CustomerHomePage = new CustomerHomePage();
            CustomerHomePage.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminHomePage AdminHomePage = new AdminHomePage();
            AdminHomePage.Show();
            this.Hide();
        }
    }
}
