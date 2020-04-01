using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contact.Models;

namespace contact.Models
{
    public class TagsContext : DbContext
    {
        public DbSet<Tags> Tags { get; set; }
        public TagsContext(DbContextOptions<TagsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}