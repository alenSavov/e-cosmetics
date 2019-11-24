using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Services.Products.Models
{
    public class CreateProductInputModel
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }


        public string CategoryId { get; set; }

        [Required]
        public ICollection<IFormFile> PictFormFiles { get; set; }
    }
}
