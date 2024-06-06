using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class Possession
{
    public int Id { get; set; }

    public int SessionCode { get; set; }

    public int EmployeeId { get; set; }

    public DateTime Start { get; set; }

    public DateTime? End { get; set; }

    public int? SessionClosedById { get; set; }

    public int SessionStatus { get; set; }

    public virtual InvEmployee Employee { get; set; } = null!;

    public virtual ICollection<PossessionHistory> PossessionHistories { get; } = new List<PossessionHistory>();

    public virtual InvEmployee? SessionClosedBy { get; set; }
}
