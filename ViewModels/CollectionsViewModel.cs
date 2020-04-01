using contact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contact.ViewModels
{
    public class CollectionsViewModel
    {
        public List<Collect> Collections { get; set; }
        public IOrderedEnumerable<Collect> SortedCollections { get; set; }
        public IOrderedEnumerable<Item> Items { get; set; }
        public string userEmail { get; set; }
        public string status { get; set; }
        public List<Tags> tags { get; set; }
    }
}
