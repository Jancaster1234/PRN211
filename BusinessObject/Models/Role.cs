using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Role
{
    public string RoleName { get; set; } = null!;

    public int Id { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
