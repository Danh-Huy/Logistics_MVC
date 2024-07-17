using Logistics.Models;
using Microsoft.EntityFrameworkCore;

namespace LogisticsWeb.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post { Id = 1 , Name = "Action", DisplayOrder = 1},
                new Post { Id = 2 , Name = "SciFi", DisplayOrder = 2},
                new Post { Id = 3 , Name = "History", DisplayOrder = 3}
                );
        }
    }
}
