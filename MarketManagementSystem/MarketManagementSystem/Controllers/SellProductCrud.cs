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
    public class SellProductCrud : ICrud<SellProduct>
    {
        DataContext db = new DataContext();
        public bool Add(SellProduct entity)
        {
            if (entity != null)
            {
                db.SellProduct.Add(entity);
                db.SaveChanges();
                return true;

            }
            return false;
        }

        public bool Delete(int id)
        {
            var sellProduct = db.SellProduct.Find(id);
            if (sellProduct != null)
            {
                db.SellProduct.Remove(sellProduct);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<SellProduct> GetAll()
        {
            return db.SellProduct.Where(x => x.IsDelete == false).ToList();
        }

        public SellProduct GetById(int id)
        {
            var sellProduct = db.SellProduct.Find(id);
            if (sellProduct != null)
            {
                return sellProduct;
            }

            return null;
        }

        public bool Update(SellProduct entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
