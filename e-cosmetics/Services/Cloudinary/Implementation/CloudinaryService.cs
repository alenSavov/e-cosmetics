using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Extensions.Options;
using e_cosmetics.Services.Interfaces;

using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using e_cosmetics.Models;
using Microsoft.CodeAnalysis;

namespace e_cosmetics.Services.Cloudinary.Implementation
{
    public class CloudinaryService : ICloudinaryService
    {
        private const string CategoryPictureFolder = "CategoryPicture";
        private const string ProductPictureFolder = "ProductPicture";

        private readonly CloudinaryOptions options;
        private readonly CloudinaryDotNet.Cloudinary cloudinary;
        public CloudinaryService(IOptions<CloudinaryOptions> options)
        {
            this.options = options.Value;

            var account = new Account(
           this.options.CloudName,
           this.options.ApiKey,
           this.options.ApiSecret);

            this.cloudinary = new CloudinaryDotNet.Cloudinary(account);
        }


        private readonly Dictionary<Type, string> EntityFolders = new Dictionary<Type, string>
        {
            { typeof(Category), CategoryPictureFolder },
            { typeof(Product), ProductPictureFolder }
        };

        public ImageUploadResult UploadPicture(Type entityType, string pictureId, Stream fileStream)
        {
            if (entityType == null || string.IsNullOrEmpty(pictureId) || string.IsNullOrWhiteSpace(pictureId) || fileStream == null)
                return null;

            ImageUploadParams imageUploadParams = new ImageUploadParams
            {
                File = new FileDescription(pictureId, fileStream),
                Folder = this.EntityFolders[entityType],
                PublicId = pictureId
            };

            return this.cloudinary.Upload(imageUploadParams);
        }
        public string BuildCategoryPictureUrl(string categoryName, string imageVersion)
        {
            if (string.IsNullOrEmpty(categoryName) || string.IsNullOrEmpty(imageVersion) || string.IsNullOrWhiteSpace(categoryName) || string.IsNullOrWhiteSpace(imageVersion))
                return null;

            string path = string.Format(GlobalConstants.FilePath, CategoryPictureFolder, string.Format(GlobalConstants.CategoryPicture, categoryName));
            var pictureUrl = cloudinary.Api.UrlImgUp
                                    .Version(imageVersion).BuildUrl(path);
            return pictureUrl;
        }

        public string BuildProductPictureUrl(string productName, string imageVersion)
        {
            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(imageVersion) || string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(imageVersion))
                return null;

            string path = string.Format(GlobalConstants.FilePath, CategoryPictureFolder, string.Format(GlobalConstants.CategoryPicture, productName));
            var pictureUrl = cloudinary.Api.UrlImgUp
                                    .Version(imageVersion).BuildUrl(path);
            return pictureUrl;
        }


    }
}
