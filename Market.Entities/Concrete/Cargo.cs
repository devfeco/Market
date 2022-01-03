using Market.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entities.Concrete
{
    public class Cargo:BaseEntity,IEntity
    {
        public string Company { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Mail { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
