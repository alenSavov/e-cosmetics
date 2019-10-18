using System.Linq;
using e_cosmetics.Data;
using e_cosmetics.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace e_cosmetics.Middleware
{
    public class SeedDataMiddleware
    {
        private readonly RequestDelegate next;

        public SeedDataMiddleware(RequestDelegate next)
        {
            this.next = next;
        }


        public async Task InvokeAsync(HttpContext context
         , ApplicationDbContext dbContext
         , UserManager<User> userManager,
         RoleManager<IdentityRole> roleManager)
        {

            if (!dbContext.Roles.Any())
            {
                await this.SeedRoles(userManager, roleManager);
            }

            await this.next(context);
        }

        public async Task SeedRoles(
            UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            var adminResult = await roleManager.CreateAsync(new IdentityRole("Admin"));
        }
    }
}
