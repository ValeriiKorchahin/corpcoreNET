using Corpcore.Dtos.Company;

namespace Corpcore.Services.Company
{
    public interface ICompanyService
    {
       Task<ICollection<CompanyDto>> GetAll();
       Task<CompanyDto> GetById(Guid id);
       Task<CompanyDto> Create(CreateCompanyDto dto);
       Task<CompanyDto> Update(Guid Id, UpdateCompanyDto dto);
       Task Delete(Guid Id);
    }
}
