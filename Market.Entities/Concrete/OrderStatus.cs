using Market.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entities.Concrete
{
    public class OrderStatus:BaseEntity,IEntity
    {
        public string Status { get; set; }
        public string Description { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
