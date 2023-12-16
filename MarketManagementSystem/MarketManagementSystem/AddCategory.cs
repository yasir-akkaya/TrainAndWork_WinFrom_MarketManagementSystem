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
    public partial class AddCategory : Form
    {
        CategoryCrud categoryCrud=new CategoryCrud();
        Functions functions =new Functions();
        public AddCategory()
        {
            InitializeComponent();
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            Category Category = new Category();
            Category.Name = CategoryNameTxt.Text;
            Category.Description = CategoryDescriptionRtb.Text;
            Category.IsStatus = CategoryStatusCb.Checked;




            string CategoryImage = "";
            string imagePath = @"C:\Users\yasir\OneDrive\Masaüstü\C# Uygulamaları\MarketManagementSystem\MarketManagementSystem\Images\";
            string defaultImage = "emptyCategory.jpg";
            if (CategoryImg.Image != null)
            {
                string imageName = Guid.NewGuid() + ".jpg";
                CategoryImg.Image.Save(imagePath + imageName, ImageFormat.Jpeg);
                CategoryImage = imagePath + imageName;
            }
            else { CategoryImage = imagePath + defaultImage; }
            Category.Image = CategoryImage;


            AddCategoryMessage.Text = categoryCrud.Add(Category) ? "Category added successfully" : "An unexpected error occurred while adding Category";
            AddCategoryMessage.Visible = true;
            CategoryNameTxt.Clear();
            CategoryDescriptionRtb.Clear();
            CategoryStatusCb.Checked = false;
            CategoryImg.Image = null;

        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            AddCategoryMessage.Visible = false;

            CategoryStatusCb.Checked = true;
        }

        private void CatgeoryImageBtn_Click(object sender, EventArgs e)
        {
            functions.UploadPictureBoxImg(CategoryImg);

        }
    }
}
