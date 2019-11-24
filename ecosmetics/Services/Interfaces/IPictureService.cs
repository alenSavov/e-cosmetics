using CloudinaryDotNet.Actions;
using ecosmetics.Services.Pictures.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Services.Interfaces
{
    public interface IPictureService
    {
        Task<ImageUploadResult> UploadPictureAsync(Type entityType, string pictureId, Stream fileStream, string entityId);

        Task<IEnumerable<ImageUploadResult>> UploadPicturesAsync(ICollection<IFormFile> pictures, Type entityType, string pictureId, string entityId);

        string BuildCategoryPictureUrl(string categoryName, string imageVersion);

        string BuildArticlePictureUrl(string articleName, string imageVersion);

        string BuildProductPictureUrl(string courseName, string imageVersion);

        DelResResult DeletePicture(Type entityType, string pictureId);

        BasePictureViewModel GetCategoryPicturesById(string id);

        ProductPictureViewModel GetProductPicturesById(string id);

        IEnumerable<ProductPictureViewModel> GetAllProductPicturesById(string id);

        BasePictureViewModel GetArticlePicturesById(string id);


    }
}
