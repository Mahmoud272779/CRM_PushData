using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class SignalR
{
    public int Id { get; set; }

    public string? ConnectionId { get; set; }

    public int InvEmployeesId { get; set; }

    public bool IsOnline { get; set; }

    public virtual InvEmployee InvEmployees { get; set; } = null!;
}
