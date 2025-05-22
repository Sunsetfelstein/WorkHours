using WorkHours.Domain.Enums;

namespace WorkHours.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string? PhoneNumber { get; set; }
    public Role Role { get; set; }
    public Company Company { get; set; }
    public Guid CompanyId { get; set; }
    public Department Department { get; set; }
    public Guid DepartmentId { get; set; }
    public List<Project> InitializedProjects { get; set; } = [];
    public List<Project> ExecutingProjects { get; set; } = [];
    public List<WorkLog> WorkLogs { get; set; } = [];
    
    public User(
        string email, 
        string passwordHash, 
        Role role, 
        string firstName,
        string secondName, 
        string? phoneNumber, 
        Company company,
        Department department)
    {
        Id = Guid.NewGuid();
        Email = email;
        PasswordHash = passwordHash;
        Role = role;
        FirstName = firstName;
        SecondName = secondName;
        PhoneNumber = phoneNumber;
        Company = company;
        CompanyId = company.Id;
        Department = department;
        DepartmentId = department.Id;
    }
}