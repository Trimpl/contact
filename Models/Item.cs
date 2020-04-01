using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contact.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string IdCollection { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public string Topic { get; set; }
        public string Email { get; set; }
        public string Fields { get; set; }
        public string Img { get; set; }
        public DateTime CreateDate { get; set; }
        public List<Comments> comments { get; set; }
    }
}
