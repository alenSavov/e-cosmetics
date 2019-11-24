using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Services.Articles.Models
{
    public class ArticlesCollectionViewModel
    {
        public IEnumerable<ArticleViewModel> Articles { get; set; }
    }
}
