using Market.Shared.Entities.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entities.Concrete
{
    public class User:IdentityUser,IEntity
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Picture { get; set; }
        public string? Description { get; set; }
        public ICollection<ShoppingCard> ShoppingCards { get; set; }
        public ICollection<OrderHistory> OrderHistories { get; set; }
    }
}
