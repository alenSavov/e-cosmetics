using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecosmetics.Models;
using ecosmetics.Services.Accounts.Models;
using ecosmetics.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ecosmetics.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly IAccountService _accountService;
        private readonly UserManager<User> _userManager;

        public AccountController(SignInManager<User> signInManager,
            IAccountService accountService,
            UserManager<User> userManager)
        {
            this._signInManager = signInManager;
            this._accountService = accountService;
            this._userManager = userManager;
        }

        [Route("Login")]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            if (this.User.Identity.IsAuthenticated)
            {
                return Redirect("\\");
            }

            return this.View();
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            if (!String.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);
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

        [Route("Logout")]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [Route("Register")]
        public IActionResult Register()
        {
            return this.View();
        }

        [HttpPost]
        [Route("Register")]
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

        public IActionResult AccessDenied()
        {
            return this.View();
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ChangePassword()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var hasPassword = await _userManager.HasPasswordAsync(user);
            if (!hasPassword)
            {
                return RedirectToAction(nameof(SetPassword));
            }

            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData[GlobalConstants.TempDataErrorMessageKey] = GlobalConstants.InvalidData;
                return View(model);
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var changePasswordResult = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
            if (!changePasswordResult.Succeeded)
            {
                //AddErrors(changePasswordResult);
                return View(model);
            }

            await _signInManager.SignInAsync(user, isPersistent: false);

            TempData[GlobalConstants.TempDataSuccessMessageKey] = GlobalConstants.PasswordChanged;
            return Redirect("/");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> SetPassword()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (user.PasswordHash == null)
            {
                TempData[GlobalConstants.TempDataErrorMessageKey] = "Your password can not be changed.";
                return Redirect("/");
            }

            var hasPassword = await _userManager.HasPasswordAsync(user);

            if (hasPassword)
            {
                return RedirectToAction(nameof(ChangePassword));
            }

            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> SetPassword(SetPasswordInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var addPasswordResult = await _userManager.AddPasswordAsync(user, model.NewPassword);
            if (!addPasswordResult.Succeeded)
            {
                //AddErrors(addPasswordResult);
                //return View(model);
            }

            await _signInManager.SignInAsync(user, isPersistent: false);
            //StatusMessage = "Your password has been set.";

            return RedirectToAction(nameof(SetPassword));
        }
    }
}
