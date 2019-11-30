using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ecosmetics.Services.Products.Models
{
    public class CreateProductInputModel
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string NameEn { get; set; }


        [Required]
        public string Description { get; set; }

     
        public string DescriptionEn { get; set; }


        public string CategoryId { get; set; }

        [Required]
        public ICollection<IFormFile> PictFormFiles { get; set; }
    }
}
