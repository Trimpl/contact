using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contact.Models
{
    public class StickerContext : DbContext
    {
        public DbSet<Sticker> AspNetStickers { get; set; }
        public StickerContext(DbContextOptions<StickerContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
