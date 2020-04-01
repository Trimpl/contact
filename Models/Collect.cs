using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contact.Models
{
    public class Collect
    {
        public string Id { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public string Theme { get; set; }
        public string Img { get; set; }
        public string Email { get; set; }
        public List<Item> Item { get; set; }
        public string Fields { get; set; }
    }
}
