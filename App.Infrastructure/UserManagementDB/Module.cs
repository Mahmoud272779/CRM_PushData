using System;
using System.Collections.Generic;

namespace App.Infrastructure.UserManagementDB;

public partial class Module
{
    public int ModuleId { get; set; }

    public string? LatinName { get; set; }

    public string ArabicName { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ICollection<ApplicationUser> Users { get; } = new List<ApplicationUser>();
}
