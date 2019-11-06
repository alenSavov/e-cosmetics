using System.Threading.Tasks;
using System.Collections.Generic;
using e_cosmetics.Services.Products.Models;

namespace e_cosmetics.Services.Products.Contracts
{
    public interface IProductService
    {
        Task<bool> CreateAsync(CreateProductInputModel model);

        IEnumerable<ProductViewModel> GetAll();

        Task<bool> DeleteAsync(string id);

        ProductViewModel GetById(string id);

        IEnumerable<ProductViewModel> GetAllProductsForCategoryById(string id);

        Task<bool> EditAsync(EditProductViewModel model);

        //Task AddPicturesAsync(ICollection<Picture> pictures, string productId);
    }
}
