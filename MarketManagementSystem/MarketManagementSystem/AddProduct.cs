using MarketManagementSystem.Controllers;
using MarketManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagementSystem
{
    public partial class AddProduct : Form
    {
        ProductCrud productCrud=new ProductCrud();
        Functions functions=new Functions();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            Product Product = new Product();
            Product.Name = ProductNameTxt.Text;
            Product.Description = ProductDescriptionRtb.Text;
            Product.IsStatus = ProductStatusCb.Checked;
            Product.Stock = Convert.ToInt32(StockNud.Value);
            Product.Price = Convert.ToInt32(PriceTb.Text);
            Product.CategoryId = Convert.ToInt32(CategoryCb.SelectedValue);




            string ProductImage = "";
            string imagePath = @"C:\Users\yasir\OneDrive\Masaüstü\C# Uygulamaları\MarketManagementSystem\MarketManagementSystem\Images\";
            string defaultImage = "emptyProduct.jpg";
            if (ProductImg.Image != null)
            {
                string imageName = Guid.NewGuid() + ".jpg";
                ProductImg.Image.Save(imagePath + imageName, ImageFormat.Jpeg);
                ProductImage = imagePath + imageName;
            }
            else { ProductImage = imagePath + defaultImage; }
            Product.Image = ProductImage;


            AddProductMessage.Text = productCrud.Add(Product) ? "Product added successfully" : "An unexpected error occurred while adding product";
            AddProductMessage.Visible = true ;
            ProductNameTxt.Clear();
            ProductDescriptionRtb.Clear();
            ProductStatusCb.Checked = false;
            ProductImg.Image = null;    


        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            functions.GetCategoryToCb(CategoryCb);
            AddProductMessage.Visible = false;

            ProductStatusCb.Checked = true;
        }

        private void ProductImageBtn_Click(object sender, EventArgs e)
        {
            functions.UploadPictureBoxImg(ProductImg);
        }
    }
}
