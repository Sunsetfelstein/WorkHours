using WorkHours.Domain.Entities;
using WorkHours.Domain.Enums;

namespace WorkHours.Domain.Interfaces;

public interface IUserRepository
{
    Task AddAsync(User user);
    Task DeleteAsync(User user);
    Task UpdateAsync(User user);
    Task<User> GetByIdAsync(Guid id);
    Task<List<User>> GetAllAsync();
    Task<List<User>> GetByRole(Role role);
    Task<List<User>> GetByDepartment(Department department);
}