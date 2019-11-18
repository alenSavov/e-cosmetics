using System.Collections.Generic;
using e_cosmetics.Services.Pictures.Models;
using System.ComponentModel.DataAnnotations;

namespace e_cosmetics.Services.Products.Models
{
    public class EditProductViewModel
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public ICollection<ProductPictureViewModel> Pictures { get; set; }
    }
}
