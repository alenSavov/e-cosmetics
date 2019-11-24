using ecosmetics.Models;
using ecosmetics.Services.Articles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Services.Interfaces
{
    public interface IArticleService
    {
        Task<bool> CreateAsync(ArticleInputModel model);

        IEnumerable<ArticleViewModel> GetAll();

        Task<bool> DeleteAsync(string id);

        Task<bool> EditAsync(EditArticleInputModel model);

        Article GetById(string id);
    }
}
