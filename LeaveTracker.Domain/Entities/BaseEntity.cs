using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveTracker.Domain.Entities;

public class BaseEntity
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public string CreatedBy { get; set; } = "System";

    public DateTime UpdatedAt { get; set; }

    public string UpdatedBy { get; set; } = "System";

    public bool IsActive { get; set; } = true;
}
