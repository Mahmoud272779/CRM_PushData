using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class UsersForgetPassword
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int UserId { get; set; }

    public virtual UserAccount User { get; set; } = null!;
}
