using Market.Data.Abstract;
using Market.Entities.Concrete;
using Market.Shared.Data.Concrete.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Data.Concrete
{
    class UserRepository : EfEntityRepositoryBase<User>, IUserRepository
    {
        private UserManager<User> userManager;
        private IPasswordValidator<User> passwordValidator;
        private IPasswordHasher<User> passwordHasher;
        public UserRepository(DbContext context, UserManager<User> userManager,
            IPasswordValidator<User> passwordValidator,
            IPasswordHasher<User> passwordHasher) : base(context)
        {
            this.userManager = userManager;
            this.passwordHasher = passwordHasher;
            this.passwordValidator = passwordValidator;
        }

        public async Task<bool> CreateAnAccountAsync(string name, string mail, string password)
        {
            IdentityResult result;
            if (name != null && mail != null && password != null)
            {
                User newUser = new User();
                newUser.UserName = name;
                newUser.Email = mail;

                result = await userManager.CreateAsync(newUser, password);
                if (result.Succeeded)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public async Task<bool> DeleteAccountAsync(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user != null)
            {
                var result = await userManager.DeleteAsync(user);
                return true;
            }
            return false;
        }

        public async Task<bool> EditAccountAsync(string id, string mail, string password)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user != null)
            {
                user.Email = mail;
                IdentityResult validPass = null;
                if (!string.IsNullOrEmpty(password))
                {
                    validPass = await passwordValidator.ValidateAsync(userManager,user,password);
                    if (validPass.Succeeded)
                    {
                        user.PasswordHash = passwordHasher.HashPassword(user,password);
                    }
                }
                if (validPass.Succeeded)
                {
                    var result = await userManager.UpdateAsync(user);
                    return true;
                }
            }
            return false;
        }
    }
}
