using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using contact.ViewModels;
using contact.Models;
using Microsoft.AspNetCore.Identity;
using System;

namespace contact.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVeiwModel model)
        {
            if (ModelState.IsValid /*&& model.Email.Contains('@') && model.Email.Contains('.')*/)
            {
                User user = new User { Email = model.Name, UserName = model.Email, 
                       DateReg = model.DateReg, DateLog = model.DateReg, IsChecked = false, Status = "user"};
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            else /*if (!model.Email.Contains('@') && !model.Email.Contains('.'))*/
            {
                ModelState.AddModelError("", "Wrong email");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result =
                    await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    User useri = await _userManager.FindByNameAsync(model.Email);
                    if (useri.LockoutEnabled == true)
                    {
                        if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                        {
                            return Redirect(model.ReturnUrl);
                        }
                        else
                        {
                            User user = await _userManager.FindByNameAsync(model.Email);
                            user.DateLog = DateTime.Now.ToString();
                            IdentityResult _result = await _userManager.UpdateAsync(user);
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Your account have been blocked");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Wrong login and(or) password");
                }
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("MainPage", "Collections");
        }

        //public IActionResult Manager()
        //{
        //    return RedirectToAction("Index", "User");
        //}
    }
}