using AutoMapper;
using e_cosmetics.Data;
using e_cosmetics.Models;
using System.Collections.Generic;
using e_cosmetics.Services.Contracts;
using e_cosmetics.Services.Categories.Models;

namespace e_cosmetics.Services.Categories.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public CategoryService(ApplicationDbContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
        }

        public bool Create(string uniqueFileName, CreateCategoryInputModel model)
        {

            Category category = new Category
            {
                Name = model.Name,
                Description = model.Description,
                PicturePath = uniqueFileName
            };

            this._dbContext.Categories.Add(category);
            this._dbContext.SaveChanges();


            return true;
        }

        public IEnumerable<CategoryViewModel> GetAll()
        {
            var categories = this._dbContext
                .Categories;

            var categoriesView = _mapper.Map<List<CategoryViewModel>>(categories);

            return categoriesView;

         }

      


    }
}
