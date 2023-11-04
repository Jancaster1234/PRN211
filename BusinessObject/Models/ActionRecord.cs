using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class ActionRecord
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Action { get; set; }

    public DateTime? CreatedTime { get; set; }

    public virtual User? User { get; set; }
}
