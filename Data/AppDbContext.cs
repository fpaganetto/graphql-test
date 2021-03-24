using ExampleGraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace ExampleGraphQL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Platform> Platforms { get; set; }
    }
}
