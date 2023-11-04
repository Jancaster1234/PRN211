using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class ScheduleRecord
{
    public int Id { get; set; }

    public string? Location { get; set; }

    public string? Room { get; set; }

    public string? ClassName { get; set; }

    public string? CourseName { get; set; }

    public DateTime? Date { get; set; }

    public TimeSpan? StartTime { get; set; }

    public TimeSpan? EndTime { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? TeacherId { get; set; }

    public virtual User? Teacher { get; set; }
}
