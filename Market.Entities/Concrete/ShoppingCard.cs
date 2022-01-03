using Market.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entities.Concrete
{
    public class ShoppingCard:BaseEntity,IEntity
    {
        public Guid? ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Guid? UserId { get; set; }
        public User User { get; set; }
    }
}
