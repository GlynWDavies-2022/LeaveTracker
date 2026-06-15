using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeaveTracker.Infrastructure.Database;

public class LeaveTrackerSQLDBContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<BankHoliday> BankHolidays { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Currency> Currencies { get; set; }
    public DbSet<EmployeeApprover> EmployeeApprovers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Gender> Gender { get; set; }
    public DbSet<Illness> Illnesses { get; set; }
    public DbSet<JobTitle> JobTitles { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<LeaveRequest> LeaveRequests { get; set; }
    public DbSet<LeaveRequestDecision> LeaveRequestDecisions { get; set; }
    public DbSet<LeaveRequestDecisionReason> LeaveRequestDecisionReasons { get; set; }
    public DbSet<LeaveType> LeaveTypes { get; set; }
    public DbSet<Office> Offices { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<TimeUnit> TimeUnits { get; set; }
    public DbSet<Title> Titles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<WorkDay> WorkDays { get; set; }
    public DbSet<WorkPattern> WorkPatterns { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(LeaveTrackerSQLDBContext).Assembly);
    }
}
