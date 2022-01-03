using Market.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entities.Concrete
{
    public class Order:BaseEntity,IEntity
    {
        public Guid? UserId { get; set; }
        public User User { get; set; }
        public Guid? OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public string CargoStatus { get; set; }
        public Guid? PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
