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
    public class BuyProductCrud : ICrud<BuyProduct>
    {
        DataContext db = new DataContext();
       
        public bool Add(BuyProduct entity)
        {
            if (entity != null && (entity.UserId)!=0
                && (entity.ProductId != 0)
                && (entity.Quantity != 0))
            {
                db.BuyProduct.Add(entity);
                db.SaveChanges();
                return true;

            }
            return false;
        }

        public bool Delete(int id)
        {
            var buyProduct = db.BuyProduct.Find(id);
            if (buyProduct != null && buyProduct.İsDelete==false)
            {
                buyProduct.İsDelete = true;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<BuyProduct> GetAll()
        {
            return db.BuyProduct.Where(x => x.İsDelete == false).ToList();
        }

        public BuyProduct GetById(int id)
        {
            var buyProduct = db.BuyProduct.Find(id);
            if (buyProduct != null)
            {
                return buyProduct;
            }

            return null;
        }

        public bool Update(BuyProduct entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
