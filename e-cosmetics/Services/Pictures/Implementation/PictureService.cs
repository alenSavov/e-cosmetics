using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Extensions.Options;
using e_cosmetics.Services.Interfaces;

using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using e_cosmetics.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Concurrent;
using e_cosmetics.Data;
using System.Threading.Tasks;

namespace e_cosmetics.Services.Pictures.Implementation
{
    public class PictureService : IPictureService
    {
        private const string CategoryPictureFolder = "CategoryPicture";
        private const string ProductPictureFolder = "ProductPicture";

        private readonly CloudinaryOptions options;
        private readonly CloudinaryDotNet.Cloudinary cloudinary;
        private readonly ApplicationDbContext _dbContext;

       
        public PictureService(IOptions<CloudinaryOptions> options, ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;

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

        public async Task<ImageUploadResult> UploadPictureAsync(Type entityType, string pictureId, Stream fileStream)
        {
            if (entityType == null || string.IsNullOrEmpty(pictureId) || string.IsNullOrWhiteSpace(pictureId))
                return null;

            ImageUploadParams imageUploadParams = new ImageUploadParams
            {
                File = new FileDescription(pictureId, fileStream),
                Folder = this.EntityFolders[entityType],
                PublicId = pictureId
            };
            
            Picture picture = new Picture
            {
                Id = imageUploadParams.PublicId,
                Folder = imageUploadParams.Folder
            };

            await this._dbContext.Pictures.AddAsync(picture);
            await this._dbContext.SaveChangesAsync();

            return this.cloudinary.Upload(imageUploadParams);

        }

        public DelResResult DeletePicture(Type entityType, string pictureId)
        {
            if (entityType == null || string.IsNullOrEmpty(pictureId) || string.IsNullOrWhiteSpace(pictureId))
                return null;

            DeletionParams deletionParams = new DeletionParams($"{entityType.Name}Picture/{pictureId}");
            var delResult = cloudinary.Destroy(deletionParams);

            return null;
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