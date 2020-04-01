using System;
using System.ComponentModel.DataAnnotations;

namespace contact.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember?")]
        public bool RememberMe { get; set; }
        [Display(Name = "Date of last login")]
        public string DateLog { get; set; } = DateTime.Now.ToString();

        public string ReturnUrl { get; set; }
    }
}