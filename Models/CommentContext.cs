using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contact.Models;

namespace contact.Models
{
    public class CommentContext : DbContext
    {
        public DbSet<Comments> Comment { get; set; }
        public CommentContext(DbContextOptions<CommentContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}