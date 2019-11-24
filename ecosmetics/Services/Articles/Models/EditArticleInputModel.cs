using ecosmetics.Services.Pictures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Services.Articles.Models
{
    public class EditArticleInputModel
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public BasePictureViewModel Picture { get; set; }
    }
}

