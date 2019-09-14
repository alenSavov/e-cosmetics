using System;
using System.IO;
using CloudinaryDotNet.Actions;

namespace e_cosmetics.Services.Interfaces
{
    public interface ICloudinaryService
    {
        ImageUploadResult UploadPicture(Type entityType, string pictureId, Stream fileStream);

        string BuildCategoryPictureUrl(string categoryName, string imageVersion);

        string BuildProductPictureUrl(string courseName, string imageVersion);
    }
}
