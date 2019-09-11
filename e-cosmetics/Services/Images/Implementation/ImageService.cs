using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using e_cosmetics.Services.Images.Contracts;

namespace e_cosmetics.Services.Images.Implementation
{
    public class ImageService : IImageService
    {
        private readonly IHostingEnvironment _appEnvironment;
        public ImageService(IHostingEnvironment appEnvironment)
        {
            this._appEnvironment = appEnvironment;
        }
        
        public async Task<string> SavePictureAsync(string uniqueFileName, IFormFile picture)
        {
            string uploadsFolder = Path.Combine(_appEnvironment.WebRootPath, GlobalConstants.imageFolderName);
            uniqueFileName = Guid.NewGuid().ToString() + "_" + picture.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await picture.CopyToAsync(stream);
            }


            return uniqueFileName;
        }

        public bool DeletePicture(string uniqueFileName)
        {
            string uploadsFolder = Path.Combine(_appEnvironment.WebRootPath, GlobalConstants.imageFolderName);
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);

                return true;
            }

            return false;
        }
    }
}
