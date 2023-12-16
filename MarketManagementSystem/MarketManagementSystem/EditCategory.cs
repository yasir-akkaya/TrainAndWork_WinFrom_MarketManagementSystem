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
    public partial class EditCategory : Form
    {
        public int SelectedCategoryId { get; set; }
        Category category = new Category();
        Functions functions = new Functions();
        DataContext db = new DataContext();
        CategoryCrud categoryCrud= new CategoryCrud();
        public EditCategory()
        {
            InitializeComponent();
        }

        private void EditCategory_Load(object sender, EventArgs e)
        {
            var selectedCategory = db.Category.Find(SelectedCategoryId);


            if (selectedCategory != null)
            {
                CategoryNameTxt.Text = selectedCategory.Name;
                CategoryDescriptionRtb.Text = selectedCategory.Description;
                CategoryStatusCb.Checked = selectedCategory.IsStatus;
            }
        }
        private void UpdateCategoryBtn_Click(object sender, EventArgs e)
        {
            
            category.Name = CategoryNameTxt.Text;
            category.Description = CategoryDescriptionRtb.Text;
            category.IsStatus = CategoryStatusCb.Checked;




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
            category.Image = CategoryImage;





            if (categoryCrud.Update(category, SelectedCategoryId))
            {
                MessageBox.Show("Category updated successfully");

                CategoryNameTxt.Clear();
                CategoryDescriptionRtb.Clear();
                CategoryStatusCb.Checked = false;
                CategoryImg.Image = null;
                this.Close();
            }
            else
            {
                MessageBox.Show("An unexpected error occurred while updating category!");

            }

            

        }
    }
}
