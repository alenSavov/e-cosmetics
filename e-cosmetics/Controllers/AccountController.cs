using e_cosmetics.Models;
using e_cosmetics.ViewModels.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace e_cosmetics.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;

        public AccountController(SignInManager<User> signInManager)
        {
            this._signInManager = signInManager;
        }

        public IActionResult Login()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return Redirect("\\");
            }

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                if (model.Username == null || model.Password == null)
                {
                    return this.View(model);
                }

                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    if (returnUrl == null)
                    {

                        return RedirectToAction(nameof(HomeController.Index), "Home");
                    }

                    return RedirectToAction(returnUrl);
                }
                if (!result.Succeeded)
                {

                    TempData[GlobalConstants.TempDataErrorMessageKey] = GlobalConstants.InvalidLogin;
                    return View(model);
                }


                if (result.IsLockedOut)
                {
                    RedirectToAction(nameof(Lockout));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, GlobalConstants.InvalidLogin);
                    return View(model);
                }
            }

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Lockout()
        {
            return View();

        }
    }
}