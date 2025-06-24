using ManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Users> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Users>().HasData(
            new Users { Id = 1, FirstName = "Alice", LastName = "Smith", Role = "Admin" },
            new Users { Id = 2, FirstName = "Bob", LastName = "Brown", Role = "Manager" },
            new Users { Id = 3, FirstName = "Carol", LastName = "Davis", Role = "Salesman" },
            new Users { Id = 4, FirstName = "Dan", LastName = "White", Role = "Salesman" }
        );
    }
}
