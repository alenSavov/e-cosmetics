using Microsoft.AspNetCore.Mvc;

namespace e_cosmetics.Controllers
{
    public class ArticleController: Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}