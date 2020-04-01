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
using System.Text.Json;


namespace contact.Controllers
{
    public class ItemsController : Controller
    {
        private readonly CommentContext _comment;
        private readonly CollectionsContext _context;
        private readonly ItemContext _context2;
        private readonly UserManager<User> _userManager;
        private readonly LikeContext _like;
        private readonly TagsContext _tag;
        public ItemsController(TagsContext tag, LikeContext like, CommentContext comment, CollectionsContext context, ItemContext context2, UserManager<User> userManager)
        {
            _tag = tag;
            _like = like;
            _comment = comment;
            _userManager = userManager;
            _context = context;
            _context2 = context2;
        }
        //public string Email;
        //public string Topic;
        //public string id;
        public async Task<IActionResult> CollectionsItems(string Id)
        {
            Collect collectionUser = _context.AspNetCollection.Find(Id);
            List<Item> All = new List<Item>();
            List<Item> items = await _context2.AspNetItem.ToListAsync();
            string status = null;
            if (User.Identity.IsAuthenticated)
            {
                User user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user.UserName == collectionUser.Email || user.Status == "god" || user.Status == "admin") status = "true";
            }
            foreach (Item item in items)
            {
                if (item.IdCollection == collectionUser.Id)
                {
                    All.Add(item);
                }
            }
            ItemsViewModel model = new ItemsViewModel
            {
                Collection = collectionUser,
                Items = All,
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
            if (booles.Last() != "on") 
            {
                newBooles.Add(booles.Last());
                newBooles.Add("off");
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
                Fields = JsonSerializer.Serialize(dictionary),
                CreateDate = DateTime.Now
            };
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
                    oldTag.ItemId +=item.Id + '+' + item.Name + ',';
                    _tag.Update(oldTag);
                };
            };
            await _tag.SaveChangesAsync();
            _context2.Add(item);
            await _context2.SaveChangesAsync();
            return RedirectToRoute("default", new { controller = "Items", action = "CollectionsItems", Id = IdCollection });
        }
        string IdCollection;
        [HttpPost]
        public async Task<ActionResult> Delete()
        {
            string sss = "";
            sss += Request.Form["selectedUsers"];
            if (sss.Length != 0)
            {
                string[] ids = sss.Split(',');
                foreach (string id in ids)
                {
                    Item item = await _context2.AspNetItem.FindAsync(id);
                    IdCollection = item.IdCollection;
                    _context2.AspNetItem.Remove(item);
                    await _context2.SaveChangesAsync();
                    foreach (Tags tag in _tag.Tags.ToList())
                    {
                        if (tag.ItemId.Contains(id))
                        {
                            tag.ItemId = tag.ItemId.Replace(id + '+' + item.Name + ',', "");
                            _tag.Update(tag);
                        };
                    };
                    await _tag.SaveChangesAsync();
                    foreach (Comments comment in _comment.Comment.ToList())
                    {
                        if (comment.ItemId == id) _comment.Remove(comment);
                    };
                    await _comment.SaveChangesAsync();
                }
            }
            return RedirectToRoute("default", new { controller = "Items", action = "CollectionsItems", Id = IdCollection });
        }

        public async Task<ActionResult> EditItem(string id)
        {
            Item item = await _context2.AspNetItem.FindAsync(id);
            return View(item);
        }

        public async Task<ActionResult> EditSave(string Tag, string Name, string Id)
        {
            Item item = await _context2.AspNetItem.FindAsync(Id);
            item.Tag = Tag;
            item.Name = Name;
            _context2.Update(item);
            await _context2.SaveChangesAsync();
            return RedirectToRoute("default", new { controller = "Items", action = "CollectionsItems", Id = item.IdCollection });
        }
        public async Task<ActionResult> EditCollection(string id)
        {
            Collect collecttion = await _context.AspNetCollection.FindAsync(id);
            return View(collecttion);
        }

        public async Task<ActionResult> EditSaveCollection(string Topic, string Description, string Id)
        {
            Collect collection = _context.AspNetCollection.Find(Id);
            collection.Topic = Topic;
            collection.Description = Description;
            _context.Update(collection);
            await _context.SaveChangesAsync();
            foreach (Item item in _context2.AspNetItem)
            {
                if (item.IdCollection == Id)
                {
                    item.Topic = Topic;
                    _context2.Update(item);
                }
            }
            await _context2.SaveChangesAsync();
            return RedirectToAction("CollectionsItems", "Items", new { Id = Id });
        }

        public async Task<ActionResult> Item(string Id)
        {
            ItemViewModel model = new ItemViewModel();
            Item Item = await _context2.AspNetItem.FindAsync(Id);
            Item.comments = new List<Comments>();
            Item.comments = _comment.Comment.Where(x => x.ItemId == Id).ToList();
            model.Item = Item;
            if (_like.Like.Find(Id) != null)
            {
                model.Liked = _like.Like.Find(Id).userEmail.Split(',').Contains(User.Identity.Name);
                model.Likes = _like.Like.Find(Id).userEmail.Split(",").Length - 1;
            }
            return View(model);
        }

        public async Task<ActionResult> CreateComment(string IdItem, string Text)
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
            List<Collect> collect = _context.AspNetCollection.Where(x => (x.Fields.Contains(search) || x.Theme.Contains(search) || x.Topic.Contains(search) || x.Email.Contains(search) || x.Description.Contains(search))).ToList();
            List<Item> item = _context2.AspNetItem.Where(x => (x.Fields.Contains(search) || x.Email.Contains(search) || x.Name.Contains(search) || x.Tag.Contains(search) || x.Topic.Contains(search))).ToList();
            List<Comments> commentsText = _comment.Comment.Where(x => (x.userEmail.Contains(search) || x.Comment.Contains(search))).ToList();
            string json = "[" + JsonSerializer.Serialize(commentsText) + "," +
                JsonSerializer.Serialize(collect) + "," +
                JsonSerializer.Serialize(item) + "]";
            return Json(json);
        }
    }
}
