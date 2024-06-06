using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class UserAndPermission
{
    public int Id { get; set; }

    public int UserAccountId { get; set; }

    public int PermissionListId { get; set; }

    public DateTime Utime { get; set; }

    public virtual PermissionList PermissionList { get; set; } = null!;

    public virtual UserAccount UserAccount { get; set; } = null!;
}
