using Market.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entities.Concrete
{
    public class PaymentMethod:BaseEntity,IEntity
    {
        public string Method { get; set; }
        public string Description { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
