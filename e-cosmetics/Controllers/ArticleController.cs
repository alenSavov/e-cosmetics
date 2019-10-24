using e_cosmetics.Services.Articles.Models;
using e_cosmetics.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace e_cosmetics.Controllers
{
    public class ArticleController: Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            this._articleService = articleService;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ArticleInputModel model)
        {

            var article = await this._articleService.CreateAsync(model);
            return View();
        }
    }
}