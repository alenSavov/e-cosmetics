using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Services.Pictures.Models
{
    public class ProductPictureViewModel
    {
        public string Id { get; set; }

        public string Url { get; set; }

        public string Folder { get; set; }

        public string VersionPicture { get; set; }

        public string ProductId { get; set; }
    }
}
