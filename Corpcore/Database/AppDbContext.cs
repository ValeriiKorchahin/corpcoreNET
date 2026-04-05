using Corpcore.Models;
using Microsoft.EntityFrameworkCore;

namespace Corpcore.Database
{
    public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
    {
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<User> Users { get; set; } 
    }
}
