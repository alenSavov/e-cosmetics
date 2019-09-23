using e_cosmetics.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace e_cosmetics.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Picture> Pictures { get; set; }

        public DbSet<ProductPicture> ProductPictures { get; set; }

        public DbSet<CategoryPicture> CategoryPictures { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Category>()
                .HasMany(p => p.Products)
                .WithOne(c => c.Category)
                .HasForeignKey(f => f.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Entity<Category>()
                .HasOne(p => p.CategoryPicture)
                .WithOne(p => p.Category)
                .HasForeignKey<CategoryPicture>(f => f.CategoryId);

            builder
             .Entity<Product>()
             .HasMany(p => p.ProductPictures)
             .WithOne(pr => pr.Product)
             .HasForeignKey(pr => pr.ProductId)
             .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(builder);
        }
    }

}
