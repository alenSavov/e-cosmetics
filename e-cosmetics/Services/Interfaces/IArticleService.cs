using System.Threading.Tasks;
using System.Collections.Generic;
using e_cosmetics.Services.Articles.Models;
using e_cosmetics.Models;

namespace e_cosmetics.Services.Interfaces
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
