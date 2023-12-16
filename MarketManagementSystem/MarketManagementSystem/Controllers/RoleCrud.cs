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
    public class RoleCrud : ICrud<Role>
    {
        DataContext db =new DataContext();
        public bool Add(Role entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetAll()
        {
           return db.Role.Where(x => x.IsDelete == false).ToList();
        }

        public Role GetById(int id)
        {
            var role = db.Role.Find(id);

            if (role != null)
            {
                return role;
            }
            else { return null; }
        }

        public bool Update(Role entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
