using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Models
{
    public class ProductPicture
    {
        public string Id { get; set; }

        public string Url { get; set; }

        public string Folder { get; set; }

        public string VersionPicture { get; set; }

        public string ProductId { get; set; }

        public Product Product { get; set; }
    }
}

