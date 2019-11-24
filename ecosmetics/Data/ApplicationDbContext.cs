using System;
using System.Collections.Generic;
using System.Text;
using ecosmetics.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ecosmetics.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Picture> Pictures { get; set; }

        public DbSet<ProductPicture> ProductPictures { get; set; }

        public DbSet<CategoryPicture> CategoryPictures { get; set; }

        public DbSet<ArticlePicture> ArticlePictures { get; set; }



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
                .Entity<Article>()
                .HasOne(p => p.ArticlePicture)
                .WithOne(p => p.Article)
                .HasForeignKey<ArticlePicture>(f => f.ArticleId);

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
