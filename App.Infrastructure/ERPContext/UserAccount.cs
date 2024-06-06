using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class UserAccount
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public bool IsActive { get; set; }

    public int EmployeesId { get; set; }

    public int? PermissionListId { get; set; }

    public DateTime UpdateTime { get; set; }

    public virtual InvEmployee Employees { get; set; } = null!;

    public virtual ICollection<OtherSetting> OtherSettings { get; } = new List<OtherSetting>();

    public virtual PermissionList? PermissionList { get; set; }

    public virtual ICollection<SigninLog> SigninLogs { get; } = new List<SigninLog>();

    public virtual ICollection<UserAndPermission> UserAndPermissions { get; } = new List<UserAndPermission>();

    public virtual ICollection<UserBranch> UserBranches { get; } = new List<UserBranch>();

    public virtual ICollection<UsersForgetPassword> UsersForgetPasswords { get; } = new List<UsersForgetPassword>();
}
