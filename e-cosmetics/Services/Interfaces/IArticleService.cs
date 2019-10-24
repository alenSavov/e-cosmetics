using e_cosmetics.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using e_cosmetics.Services.Articles.Models;

namespace e_cosmetics.Services.Interfaces
{
    public interface IArticleService
    {
        Task<bool> CreateAsync(ArticleInputModel model);

        IEnumerable<ArticleViewModel> GetAll();

        Article GetById(string id);

        Task<bool> DeleteAsync(string id);
    }
}
