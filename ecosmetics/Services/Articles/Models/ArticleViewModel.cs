using ecosmetics.Services.Pictures.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Services.Articles.Models
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
