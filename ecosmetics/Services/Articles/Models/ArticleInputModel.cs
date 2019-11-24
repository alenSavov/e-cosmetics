using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Services.Articles.Models
{
    public class ArticleInputModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string Creator { get; set; }

        [Required(ErrorMessage = "Add Image")]
        public IFormFile Picture { get; set; }
    }
}
