using Corpcore.Dtos.Utils;

namespace Corpcore.Services.Utils
{
    public interface IUtilsService
    {
       Task<ICollection<CountryDto>> GetCountries();
    }
}
