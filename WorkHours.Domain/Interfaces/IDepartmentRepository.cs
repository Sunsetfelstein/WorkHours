using WorkHours.Domain.Entities;

namespace WorkHours.Domain.Interfaces;

public interface IDepartmentRepository
{
    Task AddAsync(Department department);
    Task UpdateAsync(Department department);
    Task DeleteAsync(Department department);
    Task<Department> GetByIdAsync(Guid id);
    Task<List<Department>> GetAllAsync();
}