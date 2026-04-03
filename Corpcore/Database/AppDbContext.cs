using Microsoft.EntityFrameworkCore;

namespace Corpcore.Database
{
    public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
    {
    }
}
