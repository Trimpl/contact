using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contact.ViewModels
{
    public class EditItemViewModel
    {
        public string Id { get; set; }
        public string IdCollection { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public string Topic { get; set; }
        public string Email { get; set; }
        public int? Int1 { get; set; }
        public int? Int2 { get; set; }
        public int? Int3 { get; set; }
        public string? String1 { get; set; }
        public string? String2 { get; set; }
        public string? String3 { get; set; }
        public bool? Bool1 { get; set; }
        public bool? Bool2 { get; set; }
        public bool? Bool3 { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Date2 { get; set; }
        public DateTime Date3 { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
