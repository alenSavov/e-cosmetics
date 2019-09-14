using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace e_cosmetics.Services.Images.Contracts
{
    public interface IImageService
    {
        Task<string> SavePictureAsync(string uniqueFileName, IFormFile picture);

        bool DeletePicture(string uniqueFileName);

        bool PictureExist(string uniqueFileName);
    }
}
