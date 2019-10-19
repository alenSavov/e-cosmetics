using e_cosmetics.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using e_cosmetics.Infrastructure.AutoMapper;
using e_cosmetics.Services.Categories.Implementation;
using e_cosmetics.Services.Products.Contracts;
using e_cosmetics.Services.Products.Implementation;
using e_cosmetics.Models;
using e_cosmetics.Services.Interfaces;
using e_cosmetics.Services.Pictures.Implementation;
using e_cosmetics.Middleware;
using e_cosmetics.Services.Accounts.Implementation;
using e_cosmetics.Services.ArticleService.Implementation;

namespace e_cosmetics
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services
             .Configure<CloudinaryOptions>(options =>
             {
                 options.CloudName = this.Configuration.GetSection("Cloudinary:CloudName").Value;
                 options.ApiKey = this.Configuration.GetSection("Cloudinary:ApiKey").Value;
                 options.ApiSecret = this.Configuration.GetSection("Cloudinary:ApiSecret").Value;
             });

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            

            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfile());
            });
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<IPictureService, PictureService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IArticleService, ArticleService>();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            //services.AddDefaultIdentity<IdentityUser>()
            services.AddIdentity<User, IdentityRole>()
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password = new PasswordOptions()
                {
                    RequiredLength = 4,
                    RequiredUniqueChars = 1,
                    RequireDigit = false,
                    RequireLowercase = false,
                    RequireNonAlphanumeric = false,
                    RequireUppercase = false
                };
            });

            services.AddMvcCore().AddDataAnnotations();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                //app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSeedDataMiddleware();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
