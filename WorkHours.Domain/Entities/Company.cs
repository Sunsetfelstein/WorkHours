namespace WorkHours.Domain.Entities;

public class Company
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public User Ceo { get; set; }
    public List<User> Employees { get; set; } = [];
    public List<Department> Departments { get; set; } = [];
    
    public Company(
        string name,
        User ceo, 
        string? description)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Ceo = ceo;
    }
}