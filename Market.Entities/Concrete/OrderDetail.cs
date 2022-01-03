using Market.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entities.Concrete
{
    public class OrderDetail:BaseEntity,IEntity
    {
        public Guid? ProductId { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Guid? CargoId { get; set; }
        public Cargo Cargo { get; set; }
        public Guid? OrderId { get; set; }
        public Order Order { get; set; }
    }
}
