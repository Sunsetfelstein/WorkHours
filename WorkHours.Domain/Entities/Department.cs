namespace WorkHours.Domain.Entities;

public class Department
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public List<User> Employees { get; set; } = [];
    public User Head { get; set; }
    
    public Department(
        string name, 
        User head,
        string? description)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Head = head;
    }
}