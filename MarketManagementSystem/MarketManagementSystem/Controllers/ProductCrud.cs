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
    public class ProductCrud : ICrud<Product>
    {
        DataContext db=new DataContext();
        public bool Add(Product entity)
        {
            if (entity != null && !String.IsNullOrWhiteSpace(entity.Name)
                && !String.IsNullOrWhiteSpace(entity.Description)
                && (entity.CategoryId!=0)
                && (entity.Price!=0)
                && (entity.Stock!=0))
            {
                db.Product.Add(entity);
                db.SaveChanges();
                return true;

            }
            return false;
        }

        public bool Delete(int id)
        {
            var product = db.Product.Find(id);
            if (product != null)
            {
                db.Product.Remove(product);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Product> GetAll()
        {
            return db.Product.Where(x => x.IsDelete == false).ToList();

        }

        public Product GetById(int id)
        {
            var product = db.Product.Find(id);
            if (product != null)
            {
                return product;
            }

            return null;
        }

        public bool Update(Product entity, int id)
        {
            var product = db.Product.Find(id);
            if (product != null && !product.IsDelete)
            {
                product.Name = entity.Name;
                product.Description = entity.Description;
                product.IsStatus = entity.IsStatus;
                product.Stock = entity.Stock;
                product.Price = entity.Price;
                //product.CategoryId=entity.CategoryId;
                product.Image = entity.Image;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
