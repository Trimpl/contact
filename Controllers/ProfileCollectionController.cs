using contact.Models;
using contact.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace contact.Controllers
{
    public class ProfileCollectionController : Controller
    {
        private readonly CommentContext _comment;
        private readonly CollectionsContext _collect;
        private readonly ItemContext _item;
        private readonly UserManager<User> _userManager;
        private readonly TagsContext _tag;
        public ProfileCollectionController(CommentContext comment, TagsContext tag, CollectionsContext collect, ItemContext item, UserManager<User> userManager)
        {
            _comment = comment;
            _tag = tag;
            _userManager = userManager;
            _collect = collect;
            _item = item;
        }

        public async Task<IActionResult> Profile(string userEmail)
        {
            List<Collect> All = new List<Collect>();
            List<Collect> collections = await _collect.AspNetCollection.ToListAsync();
            List<Item> items = await _item.AspNetItem.ToListAsync();
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!User.IsInRole("Admin") && userEmail != User.Identity.Name)
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
                //Items = null,
                //SortedCollections = null,
                userEmail = userEmail,
                status = user.Status
            };
            return View(model);
        }
        public IActionResult CreateCollection(string userEmail)
        {
            CreateCollectionViewModel collection = new CreateCollectionViewModel
            {
                userEmail = userEmail
            };
            return View(collection);
        }
        [HttpPost]
        public async Task<IActionResult> Create(string userEmail, CreateCollectionViewModel model, string Fields)
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
                Topic = model.Topic,
                Description = model.Description,
                Theme = model.Theme,
                Img = model.Img,
                Email = userEmail,
                Fields = JsonConvert.SerializeObject(dictionary)
            };
            _collect.Add(collection);
            await _collect.SaveChangesAsync();
            return RedirectToRoute("default", new { controller = "ProfileCollection", action = "Profile", userEmail = userEmail });
        }
        [HttpPost]
        public async Task<ActionResult> Delete(string id, string userEmail)
        {
            Collect collection = await _collect.AspNetCollection.FindAsync(id);
            string IdCollection = collection.Id;
            List<Item> Items = _item.AspNetItem.ToList();
            foreach (Item item in Items.Where(x => x.IdCollection == IdCollection))
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
            }
            await _item.SaveChangesAsync();
            _collect.AspNetCollection.Remove(collection);
            await _collect.SaveChangesAsync();
            return RedirectToRoute("default", new { controller = "ProfileCollection", action = "Profile", userEmail = userEmail });
        }
    }
}
