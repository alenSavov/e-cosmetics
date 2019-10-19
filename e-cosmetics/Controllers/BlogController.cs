using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace e_cosmetics.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}