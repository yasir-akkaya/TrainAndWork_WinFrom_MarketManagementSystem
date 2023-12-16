using MarketManagementSystem.Controllers;
using MarketManagementSystem.Data;
using MarketManagementSystem.Entity;
using System;
using System.Collections;
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

    public partial class SalesReports : Form
    {
        DataContext db = new DataContext();
        OrderCrud orderCrud = new OrderCrud();


        public SalesReports()
        {
            InitializeComponent();
        }

        private void BackHomeBtn_Click(object sender, EventArgs e)
        {
            AdminHomePage adminHomePage = new AdminHomePage();
            adminHomePage.Show();
            this.Hide();
        }

    

        private void AllListBtn_Click(object sender, EventArgs e)
        {

            //SalesListDgv.DataSource = orderCrud.GetAll().ToList();
            var list = from Order in db.Order
                       join SellProduct in db.SellProduct on Order.Id equals SellProduct.OrderId
                       join Prod in db.Product on SellProduct.ProductId equals Prod.Id
                       select new
                       {
                           OrderId = Order.Id,
                           ProductId = Prod.Id,
                           ProductName = Prod.Name,
                           Price = Prod.Price,
                           Category = Prod.Category,
                           Quantity = SellProduct.Quantity,
                           TotalPrice = SellProduct.TotalPrice,
                           UserId = Order.UserId,
                           Date = Order.OrderDateTine,

                       };

            SalesListDgv.DataSource = list.ToList();
        }


        private void DailySalesBtn_Click(object sender, EventArgs e)
        {
            var list = from Order in db.Order
                       join SellProduct in db.SellProduct on Order.Id equals SellProduct.OrderId
                       join Prod in db.Product on SellProduct.ProductId equals Prod.Id
                       select new
                       {
                           OrderId = Order.Id,
                           ProductId = Prod.Id,
                           ProductName = Prod.Name,
                           Price = Prod.Price,
                           Category = Prod.Category,
                           Quantity = SellProduct.Quantity,
                           TotalPrice = SellProduct.TotalPrice,
                           UserId = Order.UserId,
                           Date = Order.OrderDateTine,

                       };
            DateTime lasttwentyfourhours = DateTime.Now.AddDays(-1);
            var lastDayList = list.Where(time => (DateTime.Now) >= lasttwentyfourhours);
            SalesListDgv.DataSource = lastDayList.ToList();

        }

        private void WeeklySalesBtn_Click(object sender, EventArgs e)
        {
            var list = from Order in db.Order
                       join SellProduct in db.SellProduct on Order.Id equals SellProduct.OrderId
                       join Prod in db.Product on SellProduct.ProductId equals Prod.Id
                       select new
                       {
                           OrderId = Order.Id,
                           ProductId = Prod.Id,
                           ProductName = Prod.Name,
                           Price = Prod.Price,
                           Category = Prod.Category,
                           Quantity = SellProduct.Quantity,
                           TotalPrice = SellProduct.TotalPrice,
                           UserId = Order.UserId,
                           Date = Order.OrderDateTine,

                       };
            DateTime sevendaysago = DateTime.Now.AddDays(-7);
            var lastDayList = list.Where(time => (DateTime.Now) >= sevendaysago);
            SalesListDgv.DataSource = lastDayList.ToList();

        }

        private void MonthlySalesBtn_Click(object sender, EventArgs e)
        {
            var list = from Order in db.Order
                       join SellProduct in db.SellProduct on Order.Id equals SellProduct.OrderId
                       join Prod in db.Product on SellProduct.ProductId equals Prod.Id
                       select new
                       {
                           OrderId = Order.Id,
                           ProductId = Prod.Id,
                           ProductName = Prod.Name,
                           Price = Prod.Price,
                           Category = Prod.Category,
                           Quantity = SellProduct.Quantity,
                           TotalPrice = SellProduct.TotalPrice,
                           UserId = Order.UserId,
                           Date = Order.OrderDateTine,

                       };
            DateTime thirtydaysago = DateTime.Now.AddDays(-30);
            var lastDayList = list.Where(time => (DateTime.Now) >= thirtydaysago);
            SalesListDgv.DataSource = lastDayList.ToList();
        }

        private void PopularProductsBtn_Click(object sender, EventArgs e)
        {
            var list = from Order in db.Order
                       join SellProduct in db.SellProduct on Order.Id equals SellProduct.OrderId
                       join Prod in db.Product on SellProduct.ProductId equals Prod.Id

                       select new
                       {
                           OrderId = Order.Id,
                           ProductId = Prod.Id,
                           ProductName = Prod.Name,
                           Price = Prod.Price,
                           Category = Prod.Category,
                           Quantity = SellProduct.Quantity,
                           TotalPrice = SellProduct.TotalPrice,
                           UserId = Order.UserId,
                           Date = Order.OrderDateTine,

                       };
            var salesSummaryList = from item in list
                                   group item by new { item.ProductId, item.ProductName } into grouped
                                   select new
                                   {
                                       ProductId = grouped.Key.ProductId,
                                       ProductName = grouped.Key.ProductName,
                                       SalesAmount = grouped.Sum(x => x.Quantity),
                                       TotalSalesTurnover = grouped.Sum(x => x.TotalPrice)
                                   };


            SalesListDgv.DataSource = salesSummaryList.ToList();

        }
    }
}
