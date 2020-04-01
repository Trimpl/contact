using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contact.Models
{
    public class SortedCollect
    {
        public string Id { get; set; }
        public string? Topic { get; set; }
        public string? Description { get; set; }
        public string? Theme { get; set; }
        public string? Img { get; set; }
        public string? Email { get; set; }
        public string? Int1 { get; set; }
        public string? Int2 { get; set; }
        public string? Int3 { get; set; }
        public string? String1 { get; set; }
        public string? String2 { get; set; }
        public string? String3 { get; set; }
        public string? Bool1 { get; set; }
        public string? Bool2 { get; set; }
        public string? Bool3 { get; set; }
        public string? Date1 { get; set; }
        public string? Date2 { get; set; }
        public string? Date3 { get; set; }
        public IOrderedEnumerable<Item> Item { get; set; }
    }
}
