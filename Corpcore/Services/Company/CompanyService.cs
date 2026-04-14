using Corpcore.Database;
using Corpcore.Dtos.Company;
using Corpcore.Utils.Error;
using Microsoft.EntityFrameworkCore;
using Corpcore.Services.Claims;
using Corpcore.Services.Utils;

namespace Corpcore.Services.Company
{
    public class CompanyService(
        AppDbContext _context,
        IClaimsService _claimsService,
        IUtilsService _utilsService
        ): ICompanyService
    {
        public async Task<ICollection<CompanyDto>> GetAll()
        {
            var organizationId = _claimsService.GetOrganizationId();

            var companies = await _context.Companies
                .AsNoTracking()
                .Where(c => c.OrganizationId == organizationId)
                .Select(c => new CompanyDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Established = c.Established,
                    CountryId = c.CountryId,
                    Address = c.Address,
                })
                .ToListAsync();

            return companies;
        } 

        public async Task<CompanyDto> GetById(Guid id)
        {
            var organizationId = _claimsService.GetOrganizationId();

            var company = await _context.Companies
                .AsNoTracking()
                .SingleOrDefaultAsync(c =>
                c.Id == id && c.OrganizationId == organizationId);

            if (company == null)
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, "Company not found.");
            }

            return new CompanyDto
            {
                Id = id,
                Name = company.Name,
                Address = company.Address,
                Established = company.Established,
                CountryId = company.CountryId,
            };
        }

        public async Task<CompanyDto> Create(CreateCompanyDto request) 
        {
            var organizationId = _claimsService.GetOrganizationId();

            var existingName = await _utilsService.IsExistingCountry(request.CountryId);

            if (existingName)
            {
                throw new RestException(System.Net.HttpStatusCode.Conflict, "Company with the given name already exists.");
            }

            var company = new Models.Company
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Established = request.Established,
                CountryId = request.CountryId,
                Address = request.Address,
                OrganizationId = organizationId
            };
            _context.Companies.Add(company);

            await _context.SaveChangesAsync();

            var response = new CompanyDto
            {
                Id = company.Id,
                Name = company.Name,
                Address = company.Address,
                CountryId = company.CountryId,
                Established = company.Established,
            };

            return response;
        }

        public async Task<CompanyDto> Update(Guid id, UpdateCompanyDto request) 
        {
            var organizationId = _claimsService.GetOrganizationId();

            var company = await _context.Companies
                .FirstOrDefaultAsync(c => c.OrganizationId == organizationId && c.Id == id);

            if (company == null) 
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, "Company not found.");
            }

            var nameExists = await _context.Companies
                .AnyAsync(c =>
                c.OrganizationId == organizationId &&
                c.Name == request.Name &&
                c.Id != id);

            if (nameExists)
            {
                throw new RestException(System.Net.HttpStatusCode.Conflict, "A company with given name already exists.");
            }

            var isExistingCountry = await _utilsService.IsExistingCountry(request.CountryId);

            if (!isExistingCountry) 
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, "Provided country not found.");
            }

            company.Name = request.Name;
            company.CountryId = request.CountryId;
            company.Address = request.Address;
            company.Established = request.Established;
            
            await _context.SaveChangesAsync();
            var response = new CompanyDto
            {
                Id = company.Id,
                Name = request.Name,
                CountryId = request.CountryId,
                Address = request.Address,
                Established = request.Established,
            };

            return response;
        }
        
        public async Task Delete(Guid id)
        {
            var organizationId = _claimsService.GetOrganizationId();

            var company = await _context.Companies
                .SingleOrDefaultAsync(c => c.Id == id && c.OrganizationId == organizationId);   
            
            if (company == null)
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, "Company not found.");
            }
            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();
        } 
    }
}
