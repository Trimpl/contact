using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contact.ViewModels
{
    public class CreateCollectionViewModel
    {
        public string userEmail { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public string Theme { get; set; }
        public string Img { get; set; }
    }
}
