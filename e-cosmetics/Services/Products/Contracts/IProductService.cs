using e_cosmetics.Models;
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

        Product GetById(string id);

        //Task AddPicturesAsync(ICollection<Picture> pictures, string productId);
    }
}
