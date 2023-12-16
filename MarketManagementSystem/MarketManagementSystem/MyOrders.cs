using MarketManagementSystem.Controllers;
using MarketManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagementSystem
{

    public partial class MyOrders : Form
    {
        public int CurrentUserId { get; set; }
        OrderCrud orderCrud = new OrderCrud();
        
        UserCrud userCrud = new UserCrud(); 

        public MyOrders()
        {
            InitializeComponent();
        }

        public void MyOrders_Load(object sender, EventArgs e)
        {
            var orderSearch = orderCrud.GetAll();
            var userOrders = orderSearch.Where(order => order.UserId == CurrentUserId);
            string userName = userCrud.GetById(CurrentUserId).FullName; 
            label1.Text = $" {userName}'s Orders:";

            if (Convert.ToInt32(userOrders.Count()) > 0)
            {
                UserOrdersDgv.DataSource = userOrders.ToList();
                this.UserOrdersDgv.Columns["User"].Visible = false;
                this.UserOrdersDgv.Columns["İsDelete"].Visible = false;
                UserOrdersDgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
            else
            {
                MessageBox.Show("You have no previous order!", "No Previous Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
