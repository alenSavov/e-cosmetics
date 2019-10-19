using e_cosmetics.Services.Accounts.Models;
using System.Threading.Tasks;
using e_cosmetics.Services.Interfaces;
using e_cosmetics.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using e_cosmetics.Data;

namespace e_cosmetics.Services.Accounts.Implementation
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _dbContext;

        public AccountService(UserManager<User> userManager,
            SignInManager<User> signInManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext _dbContext)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._roleManager = roleManager;
            this._dbContext = _dbContext;
        }

        public async Task<bool> Create(RegisterInputModel model)
        {
            if (model.Username == null ||
                model.Password == null ||
                model.ConfirmPassword == null ||
                model.Email == null ||
                model.FirstName == null ||
                model.LastName == null)
                return false;

            if (model.Password != model.ConfirmPassword)
            {
                return false;
            }

            var user = new User
            {
                UserName = model.Username,
                Email = model.Email,                
                FirstName = model.FirstName,
                LastName = model.LastName
            };

            var userCreateResult = await this._userManager.CreateAsync(user);

            if (userCreateResult.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);

                // Adding user to role
                if (this._userManager.Users.Count() == 1)
                {
                    if (await this._roleManager.RoleExistsAsync(GlobalConstants.ADMINISTRATOR_ROLE))
                    {
                        await this._userManager.AddToRoleAsync(user, GlobalConstants.ADMINISTRATOR_ROLE);
                    }
                }
                else
                {
                    if (await this._roleManager.RoleExistsAsync(GlobalConstants.EMPLOYEE_ROLE))
                    {
                        await this._userManager.AddToRoleAsync(user, GlobalConstants.EMPLOYEE_ROLE);
                    }
                }
            }

            return true;
        }
    }
}
