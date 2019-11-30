using ecosmetics.Services.Pictures.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ecosmetics.Services.Products.Models
{
    public class EditProductViewModel
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string NameEn { get; set; }

        [Required]
        public string Description { get; set; }

        public string DescriptionEn { get; set; }

  
        public ICollection<ProductPictureViewModel> Pictures { get; set; }
    }
}
