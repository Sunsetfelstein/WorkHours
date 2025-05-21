using WorkHours.Domain.Entities;

namespace WorkHours.Domain.Interfaces;

public interface ICompanyRepository
{
    Task AddAsync(Company company);
    Task UpdateAsync(Company company);
    Task DeleteAsync(Company company);
    Task<Company> GetByIdAsync(Guid id);
}