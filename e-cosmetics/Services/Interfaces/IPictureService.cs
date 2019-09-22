using System;
using System.IO;
using System.Threading.Tasks;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;

namespace e_cosmetics.Services.Interfaces
{
    public interface IPictureService
    {
        Task<ImageUploadResult> UploadPictureAsync(Type entityType, string pictureId, Stream fileStream);

        string BuildCategoryPictureUrl(string categoryName, string imageVersion);

        string BuildProductPictureUrl(string courseName, string imageVersion);

        DelResResult DeletePicture(Type entityType, string pictureId);

    }
}