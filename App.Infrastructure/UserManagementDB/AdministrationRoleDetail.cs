using System;
using System.Collections.Generic;

namespace App.Infrastructure.UserManagementDB;

public partial class AdministrationRoleDetail
{
    public string RoleId { get; set; } = null!;

    public int PageId { get; set; }

    public bool CanView { get; set; }

    public bool CanAdd { get; set; }

    public bool CanEdit { get; set; }

    public bool CanDelete { get; set; }

    public bool CanPrint { get; set; }

    public bool IsDefaultPage { get; set; }

    public virtual AdministrationPage Page { get; set; } = null!;

    public virtual ApplicationRole Role { get; set; } = null!;
}
