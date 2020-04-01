using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contact.Models
{
    public class Comments
    {
        public string Id { get; set; }
        public string ItemId { get; set; }
        public string Comment { get; set; }
        public string userEmail { get; set; }
        public DateTime Time { get; set; }
    }
}
