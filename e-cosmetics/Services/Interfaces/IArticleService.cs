using System.Threading.Tasks;
using System.Collections.Generic;
using e_cosmetics.Services.Articles.Models;

namespace e_cosmetics.Services.Interfaces
{
    public interface IArticleService
    {
        Task<bool> CreateAsync(ArticleInputModel model);

        IEnumerable<ArticleViewModel> GetAll();

        Task<bool> DeleteAsync(string id);

        Task<bool> EditAsync(EditArticleInputModel model);

        ArticleViewModel GetById(string id);
    }
}
