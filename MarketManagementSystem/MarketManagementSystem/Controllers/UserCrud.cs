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
    public class UserCrud : ICrud<User>
    {
        DataContext db =new DataContext();
        public bool Add(User entity)
        {
            if (entity != null && !String.IsNullOrWhiteSpace(entity.Name)
                && !String.IsNullOrWhiteSpace(entity.Surname)
                && !String.IsNullOrWhiteSpace(entity.Email)
                && !String.IsNullOrWhiteSpace(entity.Password))
            {
                db.User.Add(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var user = db.User.Find(id);
            if (user != null)
            {
                db.User.Remove(user);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<User> GetAll()
        {
            return db.User.Where(x => x.IsDelete == false).ToList();
        }

        public User GetById(int id)
        {
            var user = db.User.Find(id);
            if (user != null)
            {
                return user;
            }

            return null;
        }

        public bool Update(User entity, int id)
        {
            var user = db.User.Find(id);
            if (user != null && !user.IsDelete)
            {
                user.Name = entity.Name;
                user.Surname = entity.Surname;
                user.Email = entity.Email;
                user.Description = entity.Description;
                user.IsStatus = entity.IsStatus;
                user.RoleId = entity.RoleId;
                user.Password = entity.Password;
                user.Image = entity.Image;
                user.Password = entity.Password;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
