using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Subject
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Info { get; set; }

    public string? Major { get; set; }

    public virtual ICollection<Slot> Slots { get; set; } = new List<Slot>();
}
