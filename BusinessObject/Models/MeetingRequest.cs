using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class MeetingRequest
{
    public int Id { get; set; }

    public int? TeacherId { get; set; }

    public int? StudentId { get; set; }

    public string? Message { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Status { get; set; }

    public DateTime? ReviewedDate { get; set; }

    public int? SlotId { get; set; }

    public virtual User? Student { get; set; }

    public virtual User? Teacher { get; set; }
}
