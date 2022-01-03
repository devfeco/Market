using Market.Entities.Concrete;
using Market.Shared.Data.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Data.Abstract
{
    public interface IUserRepository : IEntityRepository<User>
    {
        Task<bool> CreateAnAccountAsync(string name, string mail, string password);
        Task<bool> EditAccountAsync(string id, string mail, string password);
        Task<bool> DeleteAccountAsync(string id);
    }
}
