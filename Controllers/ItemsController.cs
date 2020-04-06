using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using contact.Models;
using contact.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading;
using Newtonsoft.Json;


namespace contact.Controllers
{
    public class ItemsController : Controller
    {
        private readonly CommentContext _comment;
        private readonly CollectionsContext _collect;
        private readonly ItemContext _item;
        private readonly UserManager<User> _userManager;
        private readonly LikeContext _like;
        private readonly TagsContext _tag;
        public ItemsController(TagsContext tag, LikeContext like, CommentContext comment, CollectionsContext collect, ItemContext item, UserManager<User> userManager)
        {
            _tag = tag;
            _like = like;
            _comment = comment;
            _userManager = userManager;
            _collect = collect;
            _item = item;
        }
        public async Task<IActionResult> CollectionsItems(string Id)
        {
            Collect collectionUser = await _collect.AspNetCollection.FindAsync(Id);
            List<Item> All = new List<Item>();
            List<Item> items = await _item.AspNetItem.Where(x => x.IdCollection == collectionUser.Id).ToListAsync();
            string status = null;
            if (User.Identity.IsAuthenticated)
            {
                User user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user.UserName == collectionUser.Email || User.IsInRole("Admin")) status = "true";
            }
            ItemsViewModel model = new ItemsViewModel
            {
                Collection = collectionUser,
                Items = items,
                status = status,
                id = Id
            };
            return View(model);
        }
        
        public IActionResult CreateItem(string Topic, string Email, string IdCollection, string Fields)
        {
            CreateItemViewModel model = new CreateItemViewModel
            {
                Email = Email,
                Topic = Topic,
                IdCollection = IdCollection,
                Fields = Fields
            };
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Create(string img, string IdCollection, string Email, string Topic, string Name, string Tag, string Fields)
        {
            string[] integers = Request.Form["Int"];
            string[] strings = Request.Form["Str"];
            string[] dates = Request.Form["Date"];
            string[] booles = Request.Form["Bool"];
            List<string> newBooles = new List<string>();
            for (int i = 0; i < booles.Length - 1; i++)
            {
                if (booles[i] != "on" && booles[i + 1] != "on")
                {
                    newBooles.Add(booles[i]);
                    newBooles.Add("off");
                }
                else if (booles[i] != "on" && booles[i + 1] == "on")
                {
                    newBooles.Add(booles[i]);
                    newBooles.Add(booles[i + 1]);
                };
            };
            if (booles.Length != 0)
            {
                if (booles.Last() != "on")
                {
                    newBooles.Add(booles.Last());
                    newBooles.Add("off");
                };
            };
            Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>
            {
                ["int"] = integers,
                ["str"] = strings,
                ["date"] = dates,
                ["bool"] = newBooles.ToArray(),
            };
            Item item = new Item
            {
                Id = Guid.NewGuid().ToString(),
                IdCollection = IdCollection,
                Name = Name,
                Topic = Topic,
                Email = Email,
                Tag = Tag,
                Img = img,
                Fields = JsonConvert.SerializeObject(dictionary),
                CreateDate = DateTime.Now
            };
            List<string> tags = Tag.Split("#").ToList();
            tags.Remove("");
            foreach (string tag in tags)
            {
                Tags oldTag = _tag.Tags.Find(tag);
                if (oldTag == null)
                {
                    Tags newTag = new Tags
                    {
                        Id = tag,
                        ItemId = item.Id + '+' + item.Name + ',',
                        Tag = tag,
                    };
                    _tag.Add(newTag);
                }
                else
                {
                    oldTag.ItemId +=item.Id + '+' + item.Name + ',';
                    _tag.Update(oldTag);
                };
            };
            await _tag.SaveChangesAsync();
            _item.Add(item);
            await _item.SaveChangesAsync();
            return RedirectToRoute("default", new { controller = "Items", action = "CollectionsItems", Id = IdCollection });
        }

        [HttpPost]
        public async Task<ActionResult> Delete(string IdCollection)
        {
            string selectedUsers = "";
            selectedUsers += Request.Form["selectedUsers"];
            if (selectedUsers.Length != 0)
            {
                string[] ids = selectedUsers.Split(',');
                foreach (string id in ids)
                {
                    Item item = await _item.AspNetItem.FindAsync(id);
                    _item.AspNetItem.Remove(item);
                    await _item.SaveChangesAsync();
                    foreach (Tags tag in _tag.Tags.Where(x => x.ItemId.Contains(id)).ToList())
                    {
                        tag.ItemId = tag.ItemId.Replace(id + '+' + item.Name + ',', "");
                        _tag.Update(tag);
                    };
                    foreach (Comments comment in _comment.Comment.Where(x => x.ItemId == id).ToList())
                    {
                        _comment.Remove(comment);
                    };
                }
                await _tag.SaveChangesAsync();
                await _comment.SaveChangesAsync();
            }
            return RedirectToRoute("default", new { controller = "Items", action = "CollectionsItems", Id = IdCollection });
        }

        public async Task<ActionResult> EditItem(string id)
        {
            Item item = await _item.AspNetItem.FindAsync(id);
            return View(item);
        }
        [HttpPost]
        public async Task<ActionResult> EditSave(string Tag, string Name, string Id, string img)
        {
            string[] integers = Request.Form["Int"];
            string[] strings = Request.Form["Str"];
            string[] dates = Request.Form["Date"];
            string[] booles = Request.Form["Bool"];
            List<string> newBooles = new List<string>();
            for (int i = 0; i < booles.Length - 1; i++)
            {
                if (booles[i] != "on" && booles[i + 1] != "on")
                {
                    newBooles.Add(booles[i]);
                    newBooles.Add("off");
                }
                else if (booles[i] != "on" && booles[i + 1] == "on")
                {
                    newBooles.Add(booles[i]);
                    newBooles.Add(booles[i + 1]);
                };
            };
            if (booles.Length != 0)
            {
                if (booles.Last() != "on")
                {
                    newBooles.Add(booles.Last());
                    newBooles.Add("off");
                };
            };
            Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>
            {
                ["int"] = integers,
                ["str"] = strings,
                ["date"] = dates,
                ["bool"] = newBooles.ToArray(),
            };
            Item item = await _item.AspNetItem.FindAsync(Id);
            foreach (Tags tag in _tag.Tags.Where(x => x.ItemId.Contains(Id)).ToList())
            {
                tag.ItemId = tag.ItemId.Replace(Id + '+' + item.Name + ',', "");
                _tag.Update(tag);
            };
            await _tag.SaveChangesAsync();
            item.Tag = Tag;
            item.Name = Name;
            item.Img = img;
            item.Fields = JsonConvert.SerializeObject(dictionary);
            List<string> tags = Tag.Split("#").ToList();
            tags.Remove("");
            foreach (string tag in tags)
            {
                Tags newTag = new Tags();
                Tags oldTag = _tag.Tags.Find(tag);
                if (oldTag == null)
                {
                    newTag = new Tags
                    {
                        Id = tag,
                        ItemId = item.Id + '+' + item.Name + ',',
                        Tag = tag,
                    };
                    _tag.Add(newTag);
                }
                else
                {
                    if (!oldTag.ItemId.Contains(Id))
                    {
                        oldTag.ItemId += item.Id + '+' + item.Name + ',';
                        _tag.Update(oldTag);
                    };
                };
            };
            await _tag.SaveChangesAsync();
            _item.Update(item);
            await _item.SaveChangesAsync();
            return RedirectToRoute("default", new { controller = "Items", action = "CollectionsItems", Id = item.IdCollection });
        }
        public async Task<ActionResult> EditCollection(string id)
        {
            Collect collecttion = await _collect.AspNetCollection.FindAsync(id);
            return View(collecttion);
        }

        public async Task<ActionResult> EditSaveCollection(string Topic, string Description, string Id, string Theme, string img)
        {
            Collect collection = _collect.AspNetCollection.Find(Id);
            collection.Topic = Topic;
            collection.Description = Description; ;
            collection.Theme = Theme;
            collection.Img = img;
            _collect.Update(collection);
            await _collect.SaveChangesAsync();
            foreach (Item item in _item.AspNetItem.Where(x => x.IdCollection == Id).ToList())
            {
                item.Topic = Topic;
                _item.Update(item);
            }
            await _item.SaveChangesAsync();
            return RedirectToAction("CollectionsItems", "Items", new { Id = Id });
        }
        
        
        public async Task<ActionResult> Item(string Id)
        {
            ItemViewModel model = new ItemViewModel();
            Item Item = await _item.AspNetItem.FindAsync(Id);
            Item.comments = new List<Comments>();
            Item.comments = _comment.Comment.Where(x => x.ItemId == Id).ToList();
            model.Item = Item;
            if (User.Identity.IsAuthenticated)
            {
                User user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user.UserName == Item.Email || User.IsInRole("admin") || user.Status == "admin" || user.Status == "god") model.Status = true;
            }
            if (_like.Like.Find(Id) != null)
            {
                model.Liked = _like.Like.Find(Id).userEmail.Split(',').Contains(User.Identity.Name);
                model.Likes = _like.Like.Find(Id).userEmail.Split(",").Length - 1;
            }
            return View(model);
        }

        public async Task<ActionResult> CreateComment(string IdItem, string Text)
        {
            if (Text != null)
            {
                Comments comment = new Comments
                {
                    Id = Guid.NewGuid().ToString(),
                    ItemId = IdItem,
                    Comment = Text,
                    userEmail = User.Identity.Name,
                    Time = DateTime.Now
                };
                _comment.Add(comment);
                await _comment.SaveChangesAsync();
            };
            return RedirectToAction("Item", "Items", new { Id = IdItem });
        }
        public JsonResult ListComments(string IdItem)
        {
            List<Comments> List = _comment.Comment.Where(x => x.ItemId == IdItem).OrderBy(t =>t.Time).ToList();
            return Json(List);
        }
        public int Like(string ItemId)
        {
            Like itemLike = _like.Like.Find(ItemId);
            if (itemLike == null)
            {
                itemLike = new Like
                {
                    Id = ItemId,
                    ItemId = ItemId,
                    userEmail = User.Identity.Name + ",",
                };
                _like.Add(itemLike);
            }
            else
            {
                if (itemLike.userEmail.Split(',').Contains(User.Identity.Name) == false)
                {
                    itemLike.userEmail += User.Identity.Name + ",";
                    _like.Update(itemLike);
                }
                else
                {
                    string s = User.Identity.Name + ",";
                    itemLike.userEmail = itemLike.userEmail.Replace(s, "");
                    _like.Update(itemLike);
                };
            };
            _like.SaveChanges();
            return itemLike.userEmail.Split(",").Length - 1;
        }
        public JsonResult Search(string search)
        {
            List<Collect> collect = _collect.AspNetCollection.Where(x => (x.Fields.Contains(search) || x.Theme.Contains(search) || x.Topic.Contains(search) || x.Email.Contains(search) || x.Description.Contains(search))).ToList();
            List<Item> item = _item.AspNetItem.Where(x => (x.Fields.Contains(search) || x.Email.Contains(search) || x.Name.Contains(search) || x.Tag.Contains(search) || x.Topic.Contains(search))).ToList();
            List<Comments> commentsText = _comment.Comment.Where(x => (x.userEmail.Contains(search) || x.Comment.Contains(search))).ToList();
            string json = "[" + JsonConvert.SerializeObject(commentsText) + "," +
                JsonConvert.SerializeObject(collect) + "," +
                JsonConvert.SerializeObject(item) + "]";
            return Json(json);
        }
        public JsonResult TagList(string search)
        {
            if (search == null)
            {
                search = "";
            };
            string[] split = search.Split('#');
            List<string> tags = _tag.Tags.Where(x => x.Tag.Contains(split.Last())).Select(s => s.Tag).ToList();
            return Json(tags);
        }

        public async Task<ActionResult> DeleteComment(string Id)
        {
            Comments comment = await _comment.Comment.FindAsync(Id);
            string IdItem = comment.ItemId;
            _comment.Comment.Remove(comment);
            await _comment.SaveChangesAsync();
            return RedirectToAction("Item", "Items", new { Id = IdItem });
        }
    }
}
