using Market.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entities.Concrete
{
    public class OrderHistory:BaseEntity,IEntity
    {           
        public string Description { get; set; }
        public string Detail { get; set; }
        public Guid? UserId { get; set; }
        public User User { get; set; }
    }
}
