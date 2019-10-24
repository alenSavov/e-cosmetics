using e_cosmetics.Services.Articles.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e_cosmetics.Services.Interfaces
{
    public interface IArticleService
    {
        Task<bool> CreateAsync(ArticleInputModel model);

        IEnumerable<ArticleViewModel> GetAll();
    }
}
