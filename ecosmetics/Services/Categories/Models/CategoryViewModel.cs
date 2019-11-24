using ecosmetics.Services.Pictures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Services.Categories.Models
{
    public class CategoryViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public BasePictureViewModel Picture { get; set; }
    }
}
