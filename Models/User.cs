using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace contact.Models
{
    public class User : IdentityUser
    {
        public string DateReg { get; set; }
        public string DateLog { get; set; }
        public string Name { get; set; }
        public bool IsChecked { get; set; }
        public string Status { get; set; }
    }
    public class UserList
    {
        public List<User> Users { get; set; }
    }
}
