using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using CloudinaryDotNet.Actions;
using e_cosmetics.Services.Pictures.Models;
using Microsoft.AspNetCore.Http;

namespace e_cosmetics.Services.Interfaces
{
    public interface IPictureService
    {
        Task<ImageUploadResult> UploadPictureAsync(Type entityType, string pictureId, Stream fileStream, string entityId);

        Task<IEnumerable<ImageUploadResult>> UploadPicturesAsync(ICollection<IFormFile> pictures, Type entityType, string pictureId, string entityId);

        string BuildCategoryPictureUrl(string categoryName, string imageVersion);

        string BuildProductPictureUrl(string courseName, string imageVersion);

        DelResResult DeletePicture(Type entityType, string pictureId);

        BasePictureViewModel GetAllPicturesById(string id);


    }
}