using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using contact.Models;
using contact.ViewModels;
using System;
using System.Collections.Generic;
using contact.Controllers;

namespace CustomIdentityApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly CollectionsContext _context;
        private readonly ItemContext _context2;
        UserManager<User> _userManager;
        SignInManager<User> _signInManager;

        public UsersController(CollectionsContext context, ItemContext context2, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _context2 = context2;
        }

        public async Task<IActionResult> IndexAsync()
        {
            IEnumerable<User> users = _userManager.Users.ToList();
            bool check = false;
            foreach (User user in users)
            {
                if (user.UserName == User.Identity.Name && user.LockoutEnabled == true && (user.Status == "admin" || user.Status == "god"))
                {
                    return View(_userManager.Users.ToList());
                }
                else if (user.UserName == User.Identity.Name && user.LockoutEnabled == true && user.Status == "user")
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            Logout();
            return RedirectToAction("Index", "Home");
        }
        public bool Check()
        {
            IEnumerable<User> users = _userManager.Users.ToList();
            bool check = false;
            foreach (User user in users)
            {
                if (user.UserName == User.Identity.Name && user.LockoutEnabled == true)
                {
                    check = true;
                }
            }
            return check;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<ActionResult> Delete()
        {
            if (Check() == true)
            {
                string sss = "";
                sss += Request.Form["selectedUsers"];
                if (sss.Length != 0)
                {
                    string[] ids = sss.Split(',');
                    foreach (string id in ids)
                    {
                        User user = await _userManager.FindByIdAsync(id);
                        if (user.Status != "god")
                        {
                            List<Item> items = _context2.AspNetItem.ToList();
                            List<Collect> collections = _context.AspNetCollection.ToList();
                            foreach (Collect collection in collections)
                            {
                                if (collection.Email == user.UserName)
                                {
                                    foreach(Item item in items)
                                    {
                                        if (item.Email == user.UserName)
                                        {
                                            _context2.Remove(item);
                                            await _context2.SaveChangesAsync();
                                        }
                                    }
                                    _context.Remove(collection);
                                    await _context.SaveChangesAsync();
                                }
                            }
                            await _userManager.DeleteAsync(user);
                        }
                    }
                    IEnumerable<User> users = _userManager.Users.ToList();
                    foreach (User user in users)
                    {
                        if (user.UserName == User.Identity.Name)
                        {
                            return RedirectToAction("Index");
                        }
                    }
                    await Logout();
                    return RedirectToAction("Index", "Home");
                }
                return RedirectToAction("Index", "Users");
            }
            else
            {
                await Logout();
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Block()
        {
            if (Check() == true)
            {
                string sss = "";
                sss += Request.Form["selectedUsers"];
                if (sss.Length != 0)
                {
                    string[] ids = sss.Split(',');
                    foreach (string id in ids)
                    {
                        User user = await _userManager.FindByIdAsync(id);
                        user.LockoutEnabled = false;
                        var result = await _userManager.UpdateAsync(user);
                    }
                    IEnumerable<User> users = _userManager.Users.ToList();
                    foreach (User user in users)
                    {
                        if (user.UserName == User.Identity.Name)
                        {
                            if (user.LockoutEnabled == true)
                            {
                                return RedirectToAction("Index");
                            }
                            else
                            {
                                await Logout();
                                return RedirectToAction("Index", "Home");
                            }
                        }
                    }
                }
                return RedirectToAction("Index", "Users");
            }
            else
            {
                await Logout();
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public async Task<ActionResult> UnBlock()
        {
            if (Check() == true)
            {
                string sss = "";
                sss += Request.Form["selectedUsers"];
                if (sss.Length != 0)
                {
                    string[] ids = sss.Split(',');
                    foreach (string id in ids)
                    {
                        User user = await _userManager.FindByIdAsync(id);
                        user.LockoutEnabled = true;
                        var result = await _userManager.UpdateAsync(user);
                    }
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index", "Users");
            }
            else
            {
                await Logout();
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public async Task<ActionResult> Admin()
        {
            if (Check() == true)
            {
                string sss = "";
                sss += Request.Form["selectedUsers"];
                if (sss.Length != 0)
                {
                    string[] ids = sss.Split(',');
                    foreach (string id in ids)
                    {
                        User user = await _userManager.FindByIdAsync(id);
                        if (user.Status == "admin")
                        {
                            user.Status = "user";
                        }
                        else if (user.Status == "user")
                        {
                            user.Status = "admin";
                        }
                        var result = await _userManager.UpdateAsync(user);
                    }
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index", "Users");
            }
            else
            {
                await Logout();
                return RedirectToAction("Index", "Home");
            }
        }
    }
}