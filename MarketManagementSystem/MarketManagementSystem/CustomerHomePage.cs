using MarketManagementSystem.Controllers;
using MarketManagementSystem.Data;
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
    public partial class CustomerHomePage : Form
    {
        DataContext db = new DataContext();
        UserCrud userCrud = new UserCrud();
        ProductCrud productCrud = new ProductCrud();

        BuyProductCrud buyProductCrud = new BuyProductCrud();
        PictureBox ProductImgPB;
        Button ProductDetailBtn;
        Label ProductNameLbl;
        GroupBox ProductGb;
        Button DeleteProductBtn;
        Label ProductPriceLbl;
        GroupBox CartGb;
        OrderCrud orderCrud = new OrderCrud();
        SellProductCrud sellProductCrud=new SellProductCrud();


        public static int id = 0;
        public static int CurrentUserId { get; set; }
        public CustomerHomePage()
        {
            InitializeComponent();
        }

        private void CustomerHomePage_Load(object sender, EventArgs e)
        {
            int formWidth = (panel1.Width / 2) - (WelcomeTxt.Width / 2);
            int formHeight = (panel1.Height / 2) - (WelcomeTxt.Height / 2);

            WelcomeTxt.Location = new Point(formWidth, formHeight);
            WelcomeTxt.Location = new Point(formWidth, formHeight + 20);
            



            var currentUser = db.User.Find(CurrentUserId);
            var currentUserData = userCrud.GetById(CurrentUserId);
            WelcomeTxt.Text += $" {currentUserData.FullName} !";
            ProductListingIntoPanel();
        }
        private void CustomerHomePage_Activated(object sender, EventArgs e)
        {
            ProductListingIntoPanel();

            ProductListingIntoCart();

        }

        public void ProductListingIntoPanel()
        {


            int xStart = 25;
            int yStart = 25;
            int i = 0;
            int step = 170;
            int PanelWidth = 1700;

            int ProductGbCount = (PanelWidth - ((PanelWidth - xStart) % step) - xStart) / step;
            foreach (var product in productCrud.GetAll())
            {
                if (i == ProductGbCount)
                {
                    yStart += step + 90;
                    i = 0;
                }

                ProductGb = new GroupBox()
                {
                    Name = "ProductGb_" + product.Id,
                    Text = product.Name,
                    Size = new Size(150, 240),
                    BackColor = Color.White,
                    Location = new Point((i * step) + xStart, yStart)
                };
                i++;

                ProductImgPB = new PictureBox()
                {
                    Name = "ProductImgPB_" + product.Id,
                    ImageLocation = product.Image,
                    Size = new Size(120, 120),
                    Location = new Point(15, 25),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                ProductNameLbl = new Label()
                {
                    Name = "ProductName_" + product.Id,
                    Text = product.Description,
                    Location = new Point(15, 165),
                    //Name'den Id'yi alma
                    //string uid = "UserGb_13";
                    //string[] user_id = uid.Split('_');
                    //int id = Convert.ToInt32(user_id[user_id.Length - 1]);
                };
                ProductDetailBtn = new Button()
                {
                    Name = "ProductDetailBtn_" + product.Id,
                    Text = "Detail",
                    Location = new Point(15, 185),
                    Size = new Size(80, 40),
                    FlatStyle = FlatStyle.Popup,
                    BackColor = Color.DarkOliveGreen,
                    ForeColor = Color.White,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))),

                };



                //if ((i % 9) == 0)
                //{
                //    i = 0;
                //    yStart +=  step;
                //}
                ProductDetailBtn.Click += ProductDetailBtn_Click;
                ProductGb.Controls.Add(ProductDetailBtn);
                ProductGb.Controls.Add(ProductImgPB);
                ProductGb.Controls.Add(ProductNameLbl);
                ProductListPanel.Controls.Add(ProductGb);

            }

        }

        public void ProductDetailBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string btnName = btn.Name;
            string[] btnId = btnName.Split('_');
            MessageBox.Show(btnId[btnId.Length - 1]);




            CustomerHomePage.id = Convert.ToInt32(btnId[btnId.Length - 1]);
            ProductDetails productDetails = new ProductDetails();
            productDetails.ShowDialog();
        }


        public void ProductListingIntoCart()
        {


            int xStart = 10;
            int yStart = 10;
            int step = 140;
            int i = 0;


            foreach (var product in buyProductCrud.GetAll())
            {
                if (product.İsDelete == false)
                {
                    CartGb = new GroupBox()
                    {
                        Name = "CartGb_" + product.ProductId,
                        Text = $"Product {productCrud.GetById(product.ProductId).Name} X {Convert.ToString(product.Quantity)} Piece",
                        Size = new Size(130, 125),
                        BackColor = Color.White,
                        Location = new Point(xStart, yStart + (i * step))
                    };

                    i++;

                    ProductPriceLbl = new Label()
                    {
                        Name = "ProductPriceLbl_" + product.Id,
                        Text = $"Price: {Convert.ToString((product.Quantity) * productCrud.GetById(product.ProductId).Price)} TL",
                        Location = new Point(15, 45),

                    };
                    DeleteProductBtn = new Button()
                    {
                        Name = "DeleteProductBtn_" + product.Id,
                        Text = "Delete",
                        Location = new Point(15, 85),
                        Size = new Size(80, 40),
                        FlatStyle = FlatStyle.Popup,
                        BackColor = Color.Red,
                        ForeColor = Color.White,
                        Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))),

                    };
                    DeleteProductBtn.Click += DeleteProductBtn_Click;

                    CartGb.Controls.Add(DeleteProductBtn);
                    CartGb.Controls.Add(ProductPriceLbl);
                    CartPanel.Controls.Add(CartGb);
                }
            }

        }

        public void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            Button btnCart = (Button)sender;
            string btnCartName = btnCart.Name;
            string[] btnId = btnCartName.Split('_');
            CustomerHomePage.id = Convert.ToInt32(btnId[btnId.Length - 1]);
            if (CustomerHomePage.id != 0)
            {


                DialogResult dialogResult = MessageBox.Show("You will delete an item on your cart, are you sure?", "Item will be deleted!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int deletedCartProduct = Convert.ToInt32(buyProductCrud.GetById(CustomerHomePage.id).Id);
                    buyProductCrud.Delete(deletedCartProduct);
                }
                else if (dialogResult == DialogResult.No)
                {

                }
                ProductListingIntoCart();
                ProductListingIntoPanel();
            }
        }



        private void BuyCartBtn_Click(object sender, EventArgs e)
        {
            if (buyProductCrud.GetAll().Count > 0)
            {
                double totalPrice = 0;
                foreach (var cartItem in buyProductCrud.GetAll())
                {
                    var activeProduct = productCrud.GetById(cartItem.ProductId);
                    totalPrice += Convert.ToDouble((cartItem.Quantity) * (activeProduct.Price));

                }

                DialogResult dialogResult = MessageBox.Show($"Do you take the products in your cart and complete your shopping? \n Your Total Is:  {totalPrice}  TL", "Are you done?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    Order order = new Order();
                    order.UserId = CurrentUserId;
                    order.OrderDateTine = DateTime.Now;
                    orderCrud.Add(order);

                    var orderForSellProductList = orderCrud.GetById(order.Id);

                    foreach (var cartItem in buyProductCrud.GetAll())
                    {
                        var activeProduct = productCrud.GetById(cartItem.ProductId);
                        SellProduct sellProduct = new SellProduct();
                        sellProduct.OrderId = orderForSellProductList.Id;
                        sellProduct.ProductId = cartItem.ProductId;
                        sellProduct.Quantity = cartItem.Quantity;
                        sellProduct.Price = activeProduct.Price;
                        sellProduct.TotalPrice = cartItem.Quantity * activeProduct.Price;
                        sellProductCrud.Add(sellProduct);
                        buyProductCrud.Delete(cartItem.Id);
                    }
                    MessageBox.Show("Your order has been received!");
                    this.Hide();
                    this.Show();

                    ProductListingIntoPanel();
                    ProductListingIntoCart();



                }
                else if (dialogResult == DialogResult.No)
                {
                    ProductListingIntoPanel();
                    ProductListingIntoCart();
                }
            }
            else
            {
                MessageBox.Show("Your cart is empty. If you want to buy something, you can add your cart.", "Cart Is Empty");
            }
        }
        public void MyOrdersBtn_Click(object sender, EventArgs e)
        {
            MyOrders MyOrders = new MyOrders();
            MyOrders.CurrentUserId = CurrentUserId;
            MyOrders.Show();

        }

        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            EditProfile EditProfile = new EditProfile();
            EditProfile.CurrentUserId = CurrentUserId;
            EditProfile.Show();
        }
    }
}
