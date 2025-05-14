namespace WorkHours.Domain.Entities;

public class WorkLog
{
    public Guid Id { get; set; }
    public User Employee { get; set; }
    public Guid EmployeeId { get; set; }
    public Project Project { get; set; }
    public Guid ProjectId { get; set; }
    public string Description { get; set; }
    public float LaborCosts { get; set; }
    
    public WorkLog(
        User employee,
        Project project, 
        string description,
        float laborCosts)
    {
        Id = Guid.NewGuid();
        Employee = employee;
        Project = project;
        Description = description;
        LaborCosts = laborCosts;
    }
}