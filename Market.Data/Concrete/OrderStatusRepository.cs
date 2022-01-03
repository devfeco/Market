using Market.Data.Abstract;
using Market.Entities.Concrete;
using Market.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Data.Concrete
{
    public class OrderStatusRepository : EfEntityRepositoryBase<OrderStatus>, IOrderStatusRepository
    {
        public OrderStatusRepository(DbContext context) : base(context)
        {
        }
    }
}
