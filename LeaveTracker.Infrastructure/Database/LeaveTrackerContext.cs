using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeaveTracker.Infrastructure.Database;

public class LeaveTrackerContext(DbContextOptions options) : DbContext(options)
{
    public required DbSet<BankHoliday> BankHolidays { get; set; }
    public required DbSet<Company> Companies { get; set; }
    public required DbSet<Country> Countries { get; set; }
    public required DbSet<Currency> Currencies { get; set; }
    public required DbSet<EmployeeApprover> EmployeeApprovers { get; set; }
    public required DbSet<Employee> Employees { get; set; }
    public required DbSet<Gender> Gender { get; set; }
    public required DbSet<Illness> Illnesses { get; set; }
    public required DbSet<JobTitle> JobTitles { get; set; }
    public required DbSet<Language> Languages { get; set; }
    public required DbSet<LeaveRequest> LeaveRequests { get; set; }
    public required DbSet<LeaveRequestDecision> LeaveRequestDecisions { get; set; }
    public required DbSet<LeaveRequestDecisionReason> LeaveRequestDecisionReasons { get; set; }
    public required DbSet<LeaveType> LeaveTypes { get; set; }
    public required DbSet<Office> Offices { get; set; }
    public required DbSet<Permission> Permissions { get; set; }
    public required DbSet<Team> Teams { get; set; }
    public required DbSet<TimeUnit> TimeUnits { get; set; }
    public required DbSet<Title> Titles { get; set; }
    public required DbSet<WorkDay> WorkDays { get; set; }
    public required DbSet<WorkPattern> WorkPatterns { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(LeaveTrackerContext).Assembly);
    }
}
