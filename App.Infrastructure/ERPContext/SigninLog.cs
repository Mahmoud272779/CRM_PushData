using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class SigninLog
{
    public int Id { get; set; }

    public int UserAccountid { get; set; }

    public string? Token { get; set; }

    public DateTime SigninDateTime { get; set; }

    public DateTime LastActionTime { get; set; }

    public bool IsLogout { get; set; }

    public bool IsLocked { get; set; }

    public DateTime? LogoutDateTime { get; set; }

    public bool StayLoggedin { get; set; }

    public virtual UserAccount UserAccount { get; set; } = null!;
}
