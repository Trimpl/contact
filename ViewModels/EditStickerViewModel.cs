using System;
using System.ComponentModel.DataAnnotations;

namespace contact.ViewModels
{
    public class EditStickerViewModel
    {
        public string Id { get; set; }
        [Required]
        [Display(Name = "Topic")]
        public string Topic { get; set; }
        [Required]
        [Display(Name = "Text")]
        public string Text { get; set; }
    }
}
