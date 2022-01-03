using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Shared.Entities.Abstract
{
    public class AppUser:IdentityUser,IEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Guid? ShoppingCardId { get; set; }
        public ShoppingCard ShoppingCard { get; set; }
        public Guid? OrderHistoryId { get; set; }
        public OrderHistory OrderHistory { get; set; }
    }
}
