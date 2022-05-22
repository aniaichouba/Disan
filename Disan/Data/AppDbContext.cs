using Disan.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Disan.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
