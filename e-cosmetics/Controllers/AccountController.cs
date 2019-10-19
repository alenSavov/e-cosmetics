using e_cosmetics.Models;
using e_cosmetics.Services.Accounts.Models;
using e_cosmetics.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace e_cosmetics.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly IAccountService _accountService;

        public AccountController(SignInManager<User> signInManager,
            IAccountService accountService)
        {
            this._signInManager = signInManager;
            this._accountService = accountService;
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

        public IActionResult Register()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterInputModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                if (model.Username == null ||
                    model.Password == null ||
                    model.Email == null ||
                    model.FirstName == null ||
                    model.LastName == null ||
                    model.ConfirmPassword == null)
                {
                    return this.View(model);
                }

                var userCreateResult = this._accountService.Create(model);
                if (await userCreateResult)
                {
                    if (returnUrl == null)
                    {
                        return RedirectToAction(nameof(HomeController.Index), "Home");
                    }

                    return RedirectToAction(returnUrl);
                }
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Lockout()
        {
            return View();

        }
    }
}