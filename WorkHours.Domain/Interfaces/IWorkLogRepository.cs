using WorkHours.Domain.Entities;

namespace WorkHours.Domain.Interfaces;

public interface IWorkLogRepository
{
    Task AddAsync(WorkLog workLog);
    Task UpdateAsync(WorkLog workLog);
    Task DeleteAsync(WorkLog workLog);
    Task<WorkLog> GetByIdAsync(Guid id);
    Task<List<WorkLog>> GetAllAsync();
    Task<List<WorkLog>> GetByEmployee(User user);
    Task<List<WorkLog>> GetByProject(Project project);
}