using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class PossessionHistory
{
    public int Id { get; set; }

    public int PossessionId { get; set; }

    public string? ActionAr { get; set; }

    public string? ActionEn { get; set; }

    public DateTime LastDate { get; set; }

    public string? BrowserName { get; set; }

    public int EmployeesId { get; set; }

    public virtual InvEmployee Employees { get; set; } = null!;

    public virtual Possession Possession { get; set; } = null!;
}
