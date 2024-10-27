using Microsoft.EntityFrameworkCore;
using CRUDApiProject.Domain.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CRUDApiProject.Domain
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
