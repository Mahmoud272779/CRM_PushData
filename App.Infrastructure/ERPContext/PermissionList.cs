using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class PermissionList
{
    public int Id { get; set; }

    public string? ArabicName { get; set; }

    public string? LatinName { get; set; }

    public string? Note { get; set; }

    public DateTime Utime { get; set; }

    public virtual ICollection<Rule> Rules { get; } = new List<Rule>();

    public virtual ICollection<UserAccount> UserAccounts { get; } = new List<UserAccount>();

    public virtual ICollection<UserAndPermission> UserAndPermissions { get; } = new List<UserAndPermission>();
}
