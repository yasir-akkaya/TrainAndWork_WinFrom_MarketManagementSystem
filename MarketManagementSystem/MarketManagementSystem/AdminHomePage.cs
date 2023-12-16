using MarketManagementSystem.Controllers;
using MarketManagementSystem.Data;
using MarketManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagementSystem
{
    public partial class AdminHomePage : Form
    {
        DataContext db = new DataContext();
        Functions functions = new Functions();
        Product product = new Product();
        ProductCrud productCrud=new ProductCrud();
        UserCrud userCrud = new UserCrud();
        CategoryCrud categoryCrud = new CategoryCrud();
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void SalesReportsBtn_Click(object sender, EventArgs e)
        {
            SalesReports salesReports = new SalesReports();
            salesReports.Show();
            this.Hide();
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }

        private void AdminHomePage_Activated(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
            loadForm();
        }
        public void loadForm()
        {
            functions.GetUserListToDgv(UserDvg);
            functions.GetRoleListToDgv(RoleDgv);
            functions.GetProductListToDgv(ProductListDgv);
            functions.CategoryToDgv(CategoryDgv);
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            addProduct.Activate();


        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.Show();
        }

        //Edit Product

        private void EditProductBtn_Click(object sender, EventArgs e)
        {
            int selectedProductId = functions.GetSelectedRowId(ProductListDgv);
            if (selectedProductId != 0)
            {
                EditProduct editProduct = new EditProduct(this);
                editProduct.SelectedProductId = selectedProductId;
                editProduct.Show();
                editProduct.Activate();

            }
            else
            {
                MessageBox.Show("Please select the product you want to edit from the list");
            }

        }

        private void AdminHomePage_Shown(object sender, EventArgs e)
        {
            functions.GetUserListToDgv(UserDvg);
            functions.GetRoleListToDgv(RoleDgv);
            functions.GetProductListToDgv(ProductListDgv);
            functions.CategoryToDgv(CategoryDgv);

        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            var deletedProduct = functions.GetSelectedRowId(ProductListDgv);

            if (deletedProduct != 0)
            {

                DialogResult dialogResult = MessageBox.Show("You will delete an object from the database, are you sure?", "Data will be deleted!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    productCrud.Delete(deletedProduct);
                    loadForm();

                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
            else
            {
                MessageBox.Show("Please select the product you want to delete from the list");
            }


        }

        private void EditCustomerBtn_Click(object sender, EventArgs e)
        {
            int selectedUserId = functions.GetSelectedRowId(UserDvg);
            if (selectedUserId != 0)
            {
                EditCustomer editUser = new EditCustomer();
                editUser.SelectedUserId = selectedUserId;
                editUser.Show();
                editUser.Activate();

            }
            else
            {
                MessageBox.Show("Please select the product you want to edit from the list");
            }
        }

        //DElete User
        private void DeleteCustomerBtn_Click(object sender, EventArgs e)
        {
            var deletedUser = functions.GetSelectedRowId(UserDvg);

            if (deletedUser != 0)
            {

                DialogResult dialogResult = MessageBox.Show("You will delete an user from the database, are you sure?", "Data will be deleted!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    userCrud.Delete(deletedUser);
                    loadForm();

                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Please select the user you want to delete from the list");
            }
        }

        private void EditCategoryBtn_Click(object sender, EventArgs e)
        {
            int selectedCategoryId = functions.GetSelectedRowId(CategoryDgv);
            if (selectedCategoryId != 0)
            {
                EditCategory editUser = new EditCategory();
                editUser.SelectedCategoryId = selectedCategoryId;
                editUser.Show();
                editUser.Activate();

            }
            else
            {
                MessageBox.Show("Please select the category you want to edit from the list");
            }
        }

        private void DeleteCategoryBtn_Click(object sender, EventArgs e)
        {
            var deletedCategory = functions.GetSelectedRowId(CategoryDgv);

            if (deletedCategory != 0)
            {

                DialogResult dialogResult = MessageBox.Show("You will delete an Category from the database, are you sure?", "Data will be deleted!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    categoryCrud.Delete(deletedCategory);
                    loadForm();

                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Please select the user you want to delete from the list");
            }
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
