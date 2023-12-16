﻿using MarketManagementSystem.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManagementSystem.Entity
{
    public class User:CommonProperty
    {
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public List<Order> OrderList { get; set; }
        public List<BuyProduct> BuyProductList { get; set; }
        [NotMapped]
        public string FullName
        {
            get { return $"{Name} {Surname}"; }
        }
    }
}
