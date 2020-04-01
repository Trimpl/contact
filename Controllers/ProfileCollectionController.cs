using contact.Models;
using contact.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace contact.Controllers
{
    public class ProfileCollectionController : Controller
    {
        private readonly CommentContext _comment;
        private readonly CollectionsContext _context;
        private readonly ItemContext _context2;
        private readonly UserManager<User> _userManager;
        private readonly TagsContext _tag;
        public ProfileCollectionController(CommentContext comment, TagsContext tag, CollectionsContext context, ItemContext context2, UserManager<User> userManager)
        {
            _comment = comment;
            _tag = tag;
            _userManager = userManager;
            _context = context;
            _context2 = context2;
        }
        public async Task<IActionResult> Profile(string userEmail)
        {
            List<Collect> All = new List<Collect>();
            List<Collect> collections = await _context.AspNetCollection.ToListAsync();
            List<Item> items = await _context2.AspNetItem.ToListAsync();
            User user = await _userManager.FindByNameAsync(userEmail);
            User userMe = await _userManager.FindByNameAsync(User.Identity.Name);
            if ((userMe.Status != "admin" && userMe.Status != "god") && userEmail != User.Identity.Name)
            {
                return RedirectToAction("MainPage", "Collections");
            }
            foreach (Collect collection in collections)
            {
                if (collection.Email == userEmail)
                {
                    collection.Item = new List<Item>();
                    foreach (Item item in items)
                    {
                        if (item.IdCollection == collection.Id)
                        {
                            collection.Item.Add(item);
                        }
                    }
                    All.Add(collection);
                }
            }
            CollectionsViewModel model = new CollectionsViewModel
            {
                Collections = All,
                Items = null,
                SortedCollections = null,
                userEmail = userEmail,
                status = userMe.Status
            };
            return View(model);
        }
        public RedirectToActionResult IndexCollection(string Id)
        {
            return RedirectToAction("Items", "CollectionsItems", Id);
        }
        public IActionResult CreateCollection(string userEmail)
        {
            CreateCollectionViewModel collection = new CreateCollectionViewModel
            {
                userEmail = userEmail
            };
            return View(collection);
        }

        public async Task<IActionResult> CreateF(string userEmail, string topic, string description, string theme, string img, string Fields)
        {
            string[] integers = Request.Form["Int"];
            string[] strings = Request.Form["Str"];
            string[] dates = Request.Form["Date"];
            string[] booles = Request.Form["Bool"];
            Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>
            {
                ["int"] = integers,
                ["str"] = strings,
                ["date"] = dates,
                ["bool"] = booles,
            };
            Collect collection = new Collect
            {
                Id = Guid.NewGuid().ToString(),
                Topic = topic,
                Description = description,
                Theme = theme,
                Img = img,
                Email = userEmail,
                Fields = JsonSerializer.Serialize(dictionary)
        };
            _context.Add(collection);
            await _context.SaveChangesAsync();
            return RedirectToRoute("default", new { controller = "ProfileCollection", action = "Profile", userEmail = userEmail });
        }



        [HttpPost]
        public async Task<IActionResult> Create(string userEmail, string topic, string description, string theme, string? img, string? Int1, string? Int2, string? Int3, string? String1, string? String2, string? String3, string? Bool1, string? Bool2, string? Bool3, string? Date1, string? Date2, string? Date3)
        {
            Collect collection = new Collect
            {
                Id = Guid.NewGuid().ToString(),
                Topic = topic,
                Description = description,
                Theme = theme,
                Img = img,
                Email = userEmail
            };
            _context.Add(collection);
            await _context.SaveChangesAsync();
            return RedirectToRoute("default", new { controller = "ProfileCollection", action = "Profile", userEmail = userEmail });
        }
        string IdCollection;
        [HttpPost]
        public async Task<ActionResult> Delete(string id, string userEmail)
        {
            Collect collection = await _context.AspNetCollection.FindAsync(id);
            IdCollection = collection.Id;
            List<Item> Items = _context2.AspNetItem.ToList();
            foreach (Item item in Items)
            {
                if (item.IdCollection == IdCollection)
                {
                    foreach (Tags tag in _tag.Tags.ToList())
                    {
                        if (tag.ItemId.Contains(item.Id))
                        {
                            tag.ItemId = tag.ItemId.Replace(item.Id + '+' + item.Name, "");
                            _tag.Update(tag);
                            if (tag.ItemId == "") _tag.Remove(tag);
                        };
                    };
                    await _tag.SaveChangesAsync();
                    _context2.AspNetItem.Remove(item);
                    foreach (Comments comment in _comment.Comment.ToList())
                    {
                        if (comment.ItemId == item.Id) _comment.Remove(comment);
                    };
                    await _comment.SaveChangesAsync();
                }
            }
            await _context2.SaveChangesAsync();
            _context.AspNetCollection.Remove(collection);
            await _context.SaveChangesAsync();
            return RedirectToRoute("default", new { controller = "ProfileCollection", action = "Profile", userEmail = userEmail });
        }
    }
}
