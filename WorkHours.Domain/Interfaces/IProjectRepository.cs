using WorkHours.Domain.Entities;

namespace WorkHours.Domain.Interfaces;

public interface IProjectRepository
{
    Task AddAsync(Project company);
    Task UpdateAsync(Project company);
    Task DeleteAsync(Project company);
    Task<Project> GetByIdAsync(Guid id);
    Task<List<Project>> GetAllAsync();
    Task<List<Project>> GetByInitializer(User user);
    Task<List<Project>> GetByExecutor(User user);
    Task<List<Project>> GetBetween(DateTime start, DateTime end);
}