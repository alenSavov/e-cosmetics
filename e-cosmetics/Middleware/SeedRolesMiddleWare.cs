﻿using e_cosmetics.Data;
using e_cosmetics.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_cosmetics.Middleware
{
    public class SeedRolesMiddleWare
    {
        private readonly RequestDelegate next;

        public SeedRolesMiddleWare(RequestDelegate next)
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
