using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contact.Models;

namespace contact.Models
{
    public class ItemContext : DbContext
    {
        public DbSet<Item> AspNetItem { get; set; }
        public ItemContext(DbContextOptions<ItemContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}