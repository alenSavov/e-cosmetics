using System.Collections.Generic;
using System.Threading.Tasks;
using e_cosmetics.Services.Categories.Models;

namespace e_cosmetics.Services.Contracts
{
    public interface ICategoryService
    {
        IEnumerable<CategoryViewModel> GetAll();

        Task<bool> CreateAsync(string uniqueFileName, CreateCategoryInputModel model);

        Task<bool> DeleteAsync(string id);

    }
}
