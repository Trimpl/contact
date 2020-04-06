using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using contact.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace CustomIdentityApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        private readonly CollectionsContext _collect;
        private readonly ItemContext _item;
        UserManager<User> _userManager;
        SignInManager<User> _signInManager;
        RoleManager<IdentityRole> _roleManager;
        private readonly TagsContext _tag;
        private readonly CommentContext _comment;

        public UsersController(TagsContext tag, CommentContext comment, RoleManager<IdentityRole> db, CollectionsContext collect, ItemContext item, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _collect = collect;
            _item = item;
            _roleManager = db;
            _tag = tag;
            _comment = comment;
        }

        public async Task<IActionResult> IndexAsync()
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user.Status != "admin" && user.Status != "god")
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(_userManager.Users.ToList());
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
                            List<Item> items = _item.AspNetItem.ToList();
                            List<Collect> collections = _collect.AspNetCollection.ToList();
                            foreach (Collect collection in collections.Where(x => x.Email == user.UserName))
                            {
                                foreach(Item item in items.Where(x => x.Email == user.UserName))
                                {
                                    foreach (Tags tag in _tag.Tags.ToList())
                                    {
                                        if (tag.ItemId.Contains(item.Id))
                                        {
                                            tag.ItemId = tag.ItemId.Replace(item.Id + '+' + item.Name + ",", "");
                                            _tag.Update(tag);
                                        };
                                    };
                                    await _tag.SaveChangesAsync();
                                    _item.AspNetItem.Remove(item);
                                    foreach (Comments comment in _comment.Comment.ToList())
                                    {
                                        if (comment.ItemId == item.Id) _comment.Remove(comment);
                                    };
                                    await _comment.SaveChangesAsync();
                                    _item.Remove(item);
                                    await _item.SaveChangesAsync();
                                }
                                _collect.Remove(collection);
                                await _collect.SaveChangesAsync();
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
                        if (user.Status != "god")
                        {
                            user.LockoutEnabled = false;
                            await _userManager.UpdateAsync(user);
                        };
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
            await _roleManager.CreateAsync(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" });
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
                        if (await _userManager.IsInRoleAsync(user, "Admin") == true && user.Status != "god")
                        {
                            await _userManager.RemoveFromRoleAsync(user, "Admin");
                            user.Status = "user";
                        }
                        else if (await _userManager.IsInRoleAsync(user, "Admin") == false)
                        {
                            await _userManager.AddToRoleAsync(user, "Admin");
                            user.Status = "admin";
                        }
                        await _userManager.UpdateAsync(user);
                    }
                }
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