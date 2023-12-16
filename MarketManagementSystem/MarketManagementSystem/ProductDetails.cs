using MarketManagementSystem.Controllers;
using MarketManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagementSystem
{
    public partial class ProductDetails : Form
    {
        ProductCrud productCrud =new ProductCrud();
        BuyProductCrud buyProductCrud=new BuyProductCrud();
        BuyProduct buyProduct=new BuyProduct();
        
        
        public ProductDetails()
        {
            InitializeComponent();
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            int id = CustomerHomePage.id;
            var product = productCrud.GetById(id);
            
            ProductDetailImgPb.ImageLocation = product.Image;

            ProductNameDetailTxt.Text = product.Name;
            ProductDescRtb.Text = product.Description;
            StockTxt.Text += product.IsStatus ? " On Stock" : " Out Of Stock";
            StockTxt.ForeColor = product.IsStatus ? Color.Green : Color.Red;
            PriceTxt.Text += $"{product.Price} TL";
        }

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            int id = CustomerHomePage.id;
            var product = productCrud.GetById(id);
            

            if (product != null && product.IsStatus==true && QuantityNud.Value!=0 && QuantityNud.Value<product.Stock)
            {
                buyProduct.ProductId = id;
                buyProduct.Quantity = Convert.ToInt32(QuantityNud.Value);
                buyProduct.UserId = CustomerHomePage.CurrentUserId;
                buyProductCrud.Add(buyProduct);
                product.Stock -= buyProduct.Quantity;
                //sepete eklenen ürünün stoğu düşürülür::
                productCrud.Update(product, id);
                MessageBox.Show("The product has been successfully added to your cart");

            }
            else
            {
                MessageBox.Show("This product is not able to buy right now!");
            }

        }
    }
}
