using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class SlotRecord
{
    public int Id { get; set; }

    public int? SlotId { get; set; }

    public int? StudentId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual Slot? Slot { get; set; }

    public virtual User? Student { get; set; }
}
