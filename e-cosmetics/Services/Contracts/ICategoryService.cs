using e_cosmetics.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using e_cosmetics.Services.Categories.Models;

namespace e_cosmetics.Services.Contracts
{
    public interface ICategoryService
    {
        IEnumerable<CategoryViewModel> GetAll();

        Task<bool> CreateAsync(CreateCategoryInputModel model, string uniqueFileName);

        Task<bool> DeleteAsync(string id);

        //Task<bool> EditAsync(string uniqueFileName, EditCategoryInputModel model);

        Category GetById(string id);

    }
}
