using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Slot
{
    public int Id { get; set; }

    public int? TeacherId { get; set; }

    public DateTime? Date { get; set; }

    public TimeSpan? StartTime { get; set; }

    public TimeSpan? EndTime { get; set; }

    public string? Passcode { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Message { get; set; }

    public string? Status { get; set; }

    public int? SubjectId { get; set; }

    public int? StudentLimit { get; set; }

    public virtual ICollection<PasscodeRequest> PasscodeRequests { get; set; } = new List<PasscodeRequest>();

    public virtual ICollection<SlotRecord> SlotRecords { get; set; } = new List<SlotRecord>();

    public virtual Subject? Subject { get; set; }

    public virtual User? Teacher { get; set; }

    public Slot(int id, int? teacherId, DateTime? date, TimeSpan? startTime, TimeSpan? endTime, string? passcode, DateTime? createdDate, string? message, string? status, int? subjectId, int? studentLimit)
    {
        Id = id;
        TeacherId = teacherId;
        Date = date;
        StartTime = startTime;
        EndTime = endTime;
        Passcode = passcode;
        CreatedDate = createdDate;
        Message = message;
        Status = status;
        SubjectId = subjectId;
        StudentLimit = studentLimit;
    }
}
