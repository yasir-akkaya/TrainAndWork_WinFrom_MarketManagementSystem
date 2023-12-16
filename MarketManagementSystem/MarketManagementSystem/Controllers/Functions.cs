using MarketManagementSystem.Data;
using MarketManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagementSystem.Controllers
{
    public class Functions
    {
        UserCrud userCrud = new UserCrud();
        RoleCrud roleCrud = new RoleCrud();
        CategoryCrud categoryCrud = new CategoryCrud();
        ProductCrud productCrud = new ProductCrud();
        DataContext db = new DataContext();



        public void UploadPictureBoxImg(PictureBox picture)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picture.ImageLocation = ofd.FileName;
            }

        }

        public void GetRoleListToCb(ComboBox UserRoleComboBox)
        {
            UserRoleComboBox.DataSource = roleCrud.GetAll();
            UserRoleComboBox.DisplayMember = "Name";
            UserRoleComboBox.ValueMember = "Id";
        }

        public void GetUserListToDgv(DataGridView UserDvg)
        {
            UserDvg.DataSource = userCrud.GetAll();
            UserDvg.Columns["Name"].Visible = false;

        }
        public void GetCategoryToCb(ComboBox UserRoleComboBox)
        {
            UserRoleComboBox.DataSource = categoryCrud.GetAll();
            UserRoleComboBox.DisplayMember = "Name";
            UserRoleComboBox.ValueMember = "Id";
        }

        public void GetRoleListToDgv(DataGridView RoleDvg)
        {
            RoleDvg.DataSource = roleCrud.GetAll();
        }

        public void GetProductListToDgv(DataGridView ProductDgv)
        {
            ProductDgv.DataSource = productCrud.GetAll();
        }
        public void CategoryToDgv(DataGridView CategoryDgv)
        {
            CategoryDgv.DataSource = categoryCrud.GetAll();
        }

        public int GetSelectedRowId(DataGridView DataGridView)
        {
            if (DataGridView != null)
            {
                int selectedProductId = Convert.ToInt32(DataGridView.Rows[DataGridView.SelectedRows[0].Index].Cells["Id"].Value);

                return selectedProductId;
            }

            return 0;
        }

        


    }
}
