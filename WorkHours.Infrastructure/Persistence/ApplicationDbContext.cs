using Microsoft.EntityFrameworkCore;
using WorkHours.Domain.Entities;
using WorkHours.Infrastructure.Persistence.Configurations;

namespace WorkHours.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    private readonly string _connectionString;
    
    public DbSet<User> Users { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<WorkLog> WorkLogs { get; set; }
    
    public ApplicationDbContext(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_connectionString);
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}