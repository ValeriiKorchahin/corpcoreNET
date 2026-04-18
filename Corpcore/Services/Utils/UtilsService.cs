using Corpcore.Database;
using Corpcore.Dtos.Utils;
using Microsoft.EntityFrameworkCore;

namespace Corpcore.Services.Utils
{
    public class UtilsService(AppDbContext _context): IUtilsService
    {
        public async Task<ICollection<CountryDto>> GetCountries() 
        {
           return await _context.Countries
                .Select( c => new CountryDto 
                { 
                    Id = c.Id,
                    Name = c.Name,
                    Code = c.Code,
                }
                ).ToListAsync();
        }

        public async Task<bool> IsExistingCountry(Guid id)
        {
            return await _context.Countries.AnyAsync(c => c.Id == id);
        }
    }
}
