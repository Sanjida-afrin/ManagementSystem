// Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using ManagementSystem.Models;

namespace ManagementSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Data seeding
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "Alice", LastName = "Johnson", Role = "Admin" },
                new User { Id = 2, FirstName = "Bob", LastName = "Smith", Role = "Manager" },
                new User { Id = 3, FirstName = "Charlie", LastName = "Brown", Role = "Salesman" },
                new User { Id = 4, FirstName = "Diana", LastName = "Prince", Role = "Salesman" },
                new User { Id = 5, FirstName = "Evan", LastName = "Williams", Role = "Manager" }
            );
        }

        internal async Task<IEnumerable<object>> GetUsersAsync(string? role)
        {
            throw new NotImplementedException();
        }
    }
}
