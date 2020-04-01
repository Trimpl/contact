using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contact.Models;

namespace contact.Models
{
    public class CollectionsContext : DbContext
    {
        public DbSet<Collect> AspNetCollection { get; set; }
        public CollectionsContext(DbContextOptions<CollectionsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
