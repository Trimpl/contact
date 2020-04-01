using contact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contact.ViewModels
{
    public class ItemsViewModel
    {
        public Collect Collection { get; set; }
        public List<Item> Items { get; set; }
        public string status { get; set; }
        public string id { get; set; }
    }
}
