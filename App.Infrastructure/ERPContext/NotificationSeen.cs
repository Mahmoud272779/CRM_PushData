using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class NotificationSeen
{
    public int Id { get; set; }

    public int NotificationsMasterId { get; set; }

    public int UserId { get; set; }

    public bool IsAdmin { get; set; }

    public virtual NotificationsMaster NotificationsMaster { get; set; } = null!;

    public virtual InvEmployee User { get; set; } = null!;
}
