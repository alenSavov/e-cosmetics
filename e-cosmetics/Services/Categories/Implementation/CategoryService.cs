using AutoMapper;
using e_cosmetics.Data;
using e_cosmetics.Models;
using System.Collections.Generic;
using e_cosmetics.Services.Contracts;
using e_cosmetics.Services.Categories.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;
using System.Linq;
using e_cosmetics.Services.Interfaces;

namespace e_cosmetics.Services.Categories.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly IHostingEnvironment _appEnvironment;
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ICloudinaryService _cloudinaryService;


        public CategoryService(ApplicationDbContext dbContext, IMapper mapper,
            IHostingEnvironment appEnvironment,
            ICloudinaryService cloudinaryService)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
            this._appEnvironment = appEnvironment;
            this._cloudinaryService = cloudinaryService;
        }

        public async Task<bool> CreateAsync(CreateCategoryInputModel model, string imageUploadResult)
        {

            Category category = new Category
            {
                Name = model.Name,
                Description = model.Description,
                ProjectVersionPicture = imageUploadResult
            };

            this._dbContext.Categories.Add(category);
            await this._dbContext.SaveChangesAsync();


            return true;
        }

        public IEnumerable<CategoryViewModel> GetAll()
        {
            var categories = this._dbContext
                .Categories;
                      
            var categoriesView = _mapper
                .Map<List<CategoryViewModel>>(categories);

            
            return categoriesView;

        }

        public async Task<bool> DeleteAsync(string id)
        {
            var category = this._dbContext.Categories
                .FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return false;
            }

            try
            {
                this._dbContext.Categories.Remove(category);
               await this._dbContext.SaveChangesAsync();

                return true;
            }
            catch
            {

                return false;
            }

        }

        //public async Task<bool> EditAsync(EditCategoryInputModel model)
        //{
        //    var category = this._dbContext.Categories
        //        .FirstOrDefault(x => x.Id == model.Id);

        //    if (category == null)
        //    {
        //        return false;
        //    }

        //    try
        //    {
        //        category.Name = model.Name;
        //        category.Description = model.Description;
        //        category.

        //        await this._dbContext.SaveChangesAsync();

        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        public Category GetById(string id)
        {
            return this._dbContext
                 .Categories
                 .FirstOrDefault(x => x.Id == id);

        }
    }
}
