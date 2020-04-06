using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using contact.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using contact.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace contact.Controllers
{
    public class CollectionsController : Controller
    {
        private readonly CollectionsContext _context;
        private readonly ItemContext _context2;
        private readonly UserManager<User> _userManager;
        private readonly TagsContext _tag;
        SignInManager<User> _signInManager;
        public CollectionsController(SignInManager<User> signInManager, TagsContext tag, CollectionsContext context, ItemContext context2, UserManager<User> userManager)
        {
            _tag = tag;
            _userManager = userManager;
            _context = context;
            _context2 = context2;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> MainPage()
        {
            
            List<Collect> All = new List<Collect>();
            List<Collect> collections = await _context.AspNetCollection.ToListAsync();
            List<Item> items = await _context2.AspNetItem.ToListAsync();
            foreach(Collect collection in collections)
            {
                collection.Item = new List<Item>();
                foreach (Item item in items)
                {
                    if (item.IdCollection == collection.Id) collection.Item.Add(item);
                }
            }
            var sortedCollections = from u in collections
                                    orderby u.Item.Count() descending
                                    select u;
            var sortedItems = from u in items
                              orderby u.CreateDate descending
                              select u;
            CollectionsViewModel model = new CollectionsViewModel
            {
                SortedCollections = sortedCollections,
                Collections = collections,
                Items = sortedItems,
                userEmail = null,
                tags = _tag.Tags.Where(tag => tag.ItemId != "" && tag.ItemId != "," && tag.Tag != "").ToList(),
            };
            return View(model);
        }
        public RedirectToActionResult IndexCollection(string Id)
        {
            return RedirectToAction("Items", "CollectionsItems", Id);
        }

        
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("MainPage", "Collections");
        }

        public IActionResult ChangeTheme(string returnUrl)
        {
            if (Request.Cookies["theme"] == null)
            {
                Response.Cookies.Append("theme", "dark", new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });
            }
            else if (Request.Cookies["theme"] == "dark")
            {
                Response.Cookies.Delete("theme");
                Response.Cookies.Append("theme", "light", new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });
            }
            else
            {
                Response.Cookies.Delete("theme");
                Response.Cookies.Append("theme", "dark", new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });
            };
            return LocalRedirect(returnUrl);
        }
    }
}
