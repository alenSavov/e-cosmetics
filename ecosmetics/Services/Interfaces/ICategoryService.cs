using ecosmetics.Models;
using ecosmetics.Services.Categories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Services.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryViewModel> GetAll();

        Task<bool> CreateAsync(CreateCategoryInputModel model);

        Task<bool> DeleteAsync(string id);

        Task<bool> EditAsync(EditCategoryInputModel model);

        Category GetById(string id);

        //Task AddPicturesAsync(Picture picture, string categoryId);

    }
}
