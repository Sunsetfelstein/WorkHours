using WorkHours.Domain.Enums;

namespace WorkHours.Domain.Entities;

public class Project
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public User Initializer { get; set; }
    public Guid InitializerId { get; set; }
    public User? Executor { get; set; }
    public Guid? ExecutorId { get; set; }
    public DateTime? Start { get; set; }
    public DateTime? End { get; set; }
    public State State { get; set; }
    
    public Project(
        string name, 
        User initializer, 
        User? executor, 
        string? description,
        DateTime? start,
        DateTime? end)
    {
        Id = Guid.NewGuid();
        Name = name;
        Initializer = initializer;
        InitializerId = initializer.Id;
        Executor = executor;
        ExecutorId = executor?.Id;
        Description = description;
        Start = start;
        End = end;
        State = State.New;
    }
}