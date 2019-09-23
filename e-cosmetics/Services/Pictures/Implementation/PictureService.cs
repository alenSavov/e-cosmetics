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
using System.Linq;
using e_cosmetics.Services.Products.Contracts;
using e_cosmetics.Services.Pictures.Models;
using AutoMapper;

namespace e_cosmetics.Services.Pictures.Implementation
{
    public class PictureService : IPictureService
    {
        private const string CategoryPictureFolder = "CategoryPicture";
        private const string ProductPictureFolder = "ProductPicture";

        private readonly CloudinaryOptions options;
        private readonly CloudinaryDotNet.Cloudinary cloudinary;
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;


        public PictureService(IOptions<CloudinaryOptions> options, ApplicationDbContext dbContext,
            IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;

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

        public async Task<ImageUploadResult> UploadPictureAsync(Type entityType, string pictureId, Stream fileStream, string entityId)
        {
            //if (entityType == null || string.IsNullOrEmpty(pictureId) || string.IsNullOrWhiteSpace(pictureId))
            //    return null;

            ImageUploadParams imageUploadParams = new ImageUploadParams
            {
                File = new FileDescription(pictureId, fileStream),
                Folder = this.EntityFolders[entityType],
                PublicId = pictureId
            };
            //var guid = Guid.NewGuid().ToString();
            //Picture picture = new Picture
            //{
            //    Id = guid,
            //    Folder = imageUploadParams.Folder
            //};

            ////await this._dbContext.Pictures.AddAsync(picture);
            ////await this._dbContext.SaveChangesAsync();

            //var picturesToAdd = new List<Picture>();
            //picturesToAdd.Add(picture);

            //AddPicturesToEntity(entityType.Name, picturesToAdd, entityId);

            return this.cloudinary.Upload(imageUploadParams);

        }

        public async Task<IEnumerable<ImageUploadResult>> UploadPicturesAsync(ICollection<IFormFile> pictures, Type entityType, string pictureId, string entityId)
        {
            var uploadResults = new ConcurrentBag<ImageUploadResult>();
            Parallel.ForEach(pictures, (picture) =>
            {
                var guid = Guid.NewGuid().ToString();
                var uploadParams = new ImageUploadParams
                {
                    PublicId = guid,
                    File = new FileDescription(guid, picture.OpenReadStream()),
                    Folder = this.EntityFolders[entityType],
                };
                var uploadResult = this.cloudinary.UploadLarge(uploadParams);
                uploadResults.Add(uploadResult);
            });

            await AddPicturesToEntity(entityType, uploadResults, entityId);

            return uploadResults;
        }

        private async Task AddPicturesToEntity(Type entityType, ConcurrentBag<ImageUploadResult> uploadResults, string entityId)
        {

            if (entityType.Name == "Category")
            {
                var picturesToAdd = uploadResults.Select(picture => new CategoryPicture
                {
                    Id = picture.PublicId.Substring(picture.PublicId.LastIndexOf('/') + 1),
                    Folder = this.EntityFolders[entityType],
                    Url = picture.SecureUri.AbsoluteUri,
                    CategoryId = entityId,
                    VersionPicture = picture.Version

                }).ToList();

                await this._dbContext.CategoryPictures.AddRangeAsync(picturesToAdd);
                await this._dbContext.SaveChangesAsync();
            }
            else if (entityType.Name == "Product")
            {
                var picturesToAdd = uploadResults.Select(picture => new ProductPicture
                {
                    Id = picture.PublicId.Substring(picture.PublicId.LastIndexOf('/') + 1),
                    Folder = this.EntityFolders[entityType],
                    Url = picture.SecureUri.AbsoluteUri,
                    ProductId = entityId,
                    VersionPicture = picture.Version

                }).ToList();

                await this._dbContext.ProductPictures.AddRangeAsync(picturesToAdd);
                await this._dbContext.SaveChangesAsync();
            }

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

            string path = string.Format(GlobalConstants.FilePath, CategoryPictureFolder, categoryName);
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

        public BasePictureViewModel GetCategoryPicturesById(string id)
        {
            var picture = this._dbContext
                .CategoryPictures
                .FirstOrDefault(p => p.CategoryId == id);

            var picturesView = this._mapper
                .Map<BasePictureViewModel>(picture);

            return picturesView;
        }

        public ProductPictureViewModel GetProductPicturesById(string id)
        {
            var picture = this._dbContext
                .ProductPictures
                .FirstOrDefault(p => p.ProductId == id);

            var picturesView = this._mapper
                .Map<ProductPictureViewModel>(picture);

            return picturesView;
        }

        public IEnumerable<ProductPictureViewModel> GetAllProductPicturesById(string id)
        {
            var pictures = this._dbContext
                .ProductPictures
                .Where(p => p.ProductId == id);

            var picturesView = this._mapper
                .Map<IEnumerable<ProductPictureViewModel>>(pictures);

            return picturesView;
        }

    }


}