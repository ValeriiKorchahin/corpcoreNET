using Corpcore.Models;
using Microsoft.EntityFrameworkCore;

namespace Corpcore.Database
{
    public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
    {
        DbSet<Organization> Organizations { get; set; }
        DbSet<User> Users { get; set; } 
    }
}
