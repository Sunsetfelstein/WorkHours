using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkHours.Domain.Entities;

namespace WorkHours.Infrastructure.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users").HasKey(x => x.Id);

        builder.HasMany(x => x.WorkLogs)
            .WithOne(y => y.Employee)
            .HasForeignKey(y => y.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.InitializedProjects)
            .WithOne(y => y.Initializer)
            .HasForeignKey(y => y.InitializerId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.ExecutingProjects)
            .WithOne(y => y.Executor)
            .HasForeignKey(y => y.ExecutorId);
    }
}