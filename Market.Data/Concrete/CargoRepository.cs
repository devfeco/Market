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
    public class CargoRepository : EfEntityRepositoryBase<Cargo>, ICargoRepository
    {
        public CargoRepository(DbContext context) : base(context)
        {
        }
    }
}
