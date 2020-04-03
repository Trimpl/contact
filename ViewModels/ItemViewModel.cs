using contact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contact.ViewModels
{
    public class ItemViewModel
    {
        public Item Item { get; set; }
        public List<Comments> comments { get; set; }
        public int Likes { get; set; }
        public bool Liked { get; set; }
        public bool Status { get; set; }
    }
}
