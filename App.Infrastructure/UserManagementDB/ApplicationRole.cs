using System;
using System.Collections.Generic;

namespace App.Infrastructure.UserManagementDB;

public partial class ApplicationRole
{
    public string Id { get; set; } = null!;

    public string? ArabicName { get; set; }

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual ICollection<AdministrationRoleDetail> AdministrationRoleDetails { get; } = new List<AdministrationRoleDetail>();

    public virtual ICollection<ApplicationUser> ApplicationUsers { get; } = new List<ApplicationUser>();
}
