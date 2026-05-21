using LeaveTracker.Domain.Enums;

namespace LeaveTracker.Domain.Entities;

public class WorkDay : BaseEntity
{
    public WeekDay Day { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }
}
