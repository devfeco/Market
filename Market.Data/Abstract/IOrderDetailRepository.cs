﻿using Market.Entities.Concrete;
using Market.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Data.Abstract
{
    public interface IOrderDetailRepository:IEntityRepository<OrderDetail>
    {
    }
}
