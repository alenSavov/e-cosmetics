using System;
using System.ComponentModel.DataAnnotations;
using e_cosmetics.Services.Pictures.Models;

namespace e_cosmetics.Services.Articles.Models
{
    public class ArticleViewModel
    {
        public string Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Creator { get; set; }
               
        public DateTime CreatedOn { get; set; }
        
        [Required]
        public string Content { get; set; }

        public BasePictureViewModel Picture { get; set; }
    }
}
