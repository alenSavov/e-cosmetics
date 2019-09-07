using AutoMapper;
using e_cosmetics.Data;
using e_cosmetics.Models;
using e_cosmetics.Services.Contracts;
using e_cosmetics.Services.Products.Contracts;
using e_cosmetics.Services.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_cosmetics.Services.Products.Implementation
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public ProductService(
                    ICategoryService categoryService,
                    ApplicationDbContext dbContext,
                    IMapper mapper
            )
        {
            this._categoryService = categoryService;
            this._dbContext = dbContext;
            this._mapper = mapper;
        }

        public async Task<bool> CreateAsync(string uniqueFileName, CreateProductInputModel model)
        {
            Product product = new Product
            {
                Name = model.Name,
                Description = model.Description,
                PictureName = uniqueFileName,
                CategoryId = model.CategoryId
            };

            this._dbContext.Products.Add(product);
            await this._dbContext.SaveChangesAsync();

            return true;
        }
    }
}
