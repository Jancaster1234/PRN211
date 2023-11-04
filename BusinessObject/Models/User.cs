using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? DayOfBirth { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Image { get; set; }

    public string? Major { get; set; }

    public string? Info { get; set; }

    public string? UserStatus { get; set; }

    public bool? IsShowProfile { get; set; }

    public bool? IsShowSchedule { get; set; }

    public int? Role { get; set; }

    public virtual ICollection<ActionRecord> ActionRecords { get; set; } = new List<ActionRecord>();

    public virtual ICollection<MeetingRequest> MeetingRequestStudents { get; set; } = new List<MeetingRequest>();

    public virtual ICollection<MeetingRequest> MeetingRequestTeachers { get; set; } = new List<MeetingRequest>();

    public virtual ICollection<PasscodeRequest> PasscodeRequests { get; set; } = new List<PasscodeRequest>();

    public virtual Role? RoleNavigation { get; set; }

    public virtual ICollection<ScheduleRecord> ScheduleRecords { get; set; } = new List<ScheduleRecord>();

    public virtual ICollection<SlotRecord> SlotRecords { get; set; } = new List<SlotRecord>();

    public virtual ICollection<Slot> Slots { get; set; } = new List<Slot>();
}
