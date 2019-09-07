using System.IO;
using AutoMapper;
using e_cosmetics.Data;
using e_cosmetics.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using e_cosmetics.Services.Contracts;
using e_cosmetics.Services.Products.Contracts;
using e_cosmetics.Services.Products.Models;
using System.Collections;

namespace e_cosmetics.Services.Products.Implementation
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        private readonly ApplicationDbContext _dbContext;
        private readonly IHostingEnvironment _appEnvironment;
        private readonly IMapper _mapper;

        public ProductService(
                    ICategoryService categoryService,
                    ApplicationDbContext dbContext,
                    IMapper mapper,
                    IHostingEnvironment appEnvironment
            )
        {
            this._categoryService = categoryService;
            this._dbContext = dbContext;
            this._mapper = mapper;
            this._appEnvironment = appEnvironment;
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

        public IEnumerable<ProductViewModel> GetAll()
        {
            var products = this._dbContext
                .Products;

            var productsView = _mapper
                .Map<List<ProductViewModel>>(products);

            string uploadsFolder = Path.Combine(_appEnvironment.WebRootPath, GlobalConstants.imageFolderName);

            foreach (var product in productsView)
            {
                string filePath = Path.Combine(uploadsFolder, product.PictureName);
                product.PictureName = $"{GlobalConstants.imageFolderPath}{product.PictureName}";
            }

            return productsView;
        }
    }
}
