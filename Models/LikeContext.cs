using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contact.Models
{
    public class LikeContext : DbContext
    {
        public DbSet<Like> Like { get; set; }
        public LikeContext(DbContextOptions<LikeContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
