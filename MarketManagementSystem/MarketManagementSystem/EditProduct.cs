using MarketManagementSystem.Controllers;
using MarketManagementSystem.Data;
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
    public partial class EditProduct : Form
    {
        DataContext db = new DataContext();
        Functions functions = new Functions();
        ProductCrud productCrud = new ProductCrud();
        Product product = new Product();
        public int SelectedProductId { get; set; }
        public AdminHomePage adminHomePage;
        public EditProduct(AdminHomePage adminHomePage)
        {
            InitializeComponent();
            this.adminHomePage = adminHomePage;
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {

            var selectedProduct = db.Product.Find(SelectedProductId);
            //functions.GetCategoryToCb(CategoryCb);
            AddProductMessage.Visible = false;


            if (selectedProduct != null)
            {
                ProductNameTxt.Text = selectedProduct.Name;
                ProductDescriptionRtb.Text = selectedProduct.Description;
                StockNud.Value = selectedProduct.Stock;
                PriceTb.Text = Convert.ToString(selectedProduct.Price);
                ProductStatusCb.Checked = selectedProduct.IsStatus;
                //ProductImg.Image = functions.UploadPictureBoxImg(selectedProduct.Image);
            }
        }

        private void UpdateProductBtn_Click(object sender, EventArgs e)
        {

            product.Name = ProductNameTxt.Text;
            product.Description = ProductDescriptionRtb.Text;
            product.Stock = Convert.ToInt32(StockNud.Value);
            product.Price = Convert.ToDouble(PriceTb.Text);
            product.IsStatus = ProductStatusCb.Checked;

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
            product.Image = ProductImage;


            if (productCrud.Update(product, SelectedProductId))
            {
                MessageBox.Show("Product updated successfully");

                ProductNameTxt.Clear();
                ProductDescriptionRtb.Clear();
                ProductStatusCb.Checked = false;
                ProductImg.Image = null;

            }
            else
            {
                MessageBox.Show("An unexpected error occurred while updating product");

            }



        }

        private void ProductImageBtn_Click(object sender, EventArgs e)
        {
            functions.UploadPictureBoxImg(ProductImg);
        }

        private void EditProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            adminHomePage.loadForm();
        }
    }
}
