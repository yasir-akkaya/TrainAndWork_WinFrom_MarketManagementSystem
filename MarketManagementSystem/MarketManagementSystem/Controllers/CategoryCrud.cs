using MarketManagementSystem.Data;
using MarketManagementSystem.Entity;
using MarketManagementSystem.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManagementSystem.Controllers
{
    internal class CategoryCrud : ICrud<Category>
    {
        DataContext db=new DataContext();
        public bool Add(Category entity)
        {
            if (entity != null && !String.IsNullOrWhiteSpace(entity.Name)
                && !String.IsNullOrWhiteSpace(entity.Description))
                
            {
                db.Category.Add(entity);
                db.SaveChanges();
                return true;

            }
            return false;
        }

        public bool Delete(int id)
        {
            var category = db.Category.Find(id);
            if (category != null)
            {
                db.Category.Remove(category);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Category> GetAll()
        {
            return db.Category.Where(x => x.IsDelete == false).ToList();

        }

        public Category GetById(int id)
        {
            var category = db.Category.Find(id);
            if (category != null)
            {
                return category;
            }

            return null;
        }

        public bool Update(Category entity, int id)
        {
            var category = db.Category.Find(id);
            if (category != null && !category.IsDelete)
            {
                category.Name = entity.Name;
                category.Description = entity.Description;
                category.IsStatus = entity.IsStatus;
                category.Image = entity.Image;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
