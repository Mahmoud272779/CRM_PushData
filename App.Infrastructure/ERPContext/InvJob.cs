using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvJob
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string ArabicName { get; set; } = null!;

    public string? LatinName { get; set; }

    public int Status { get; set; }

    public string? Notes { get; set; }

    public bool CanDelete { get; set; }

    public virtual ICollection<InvEmployee> InvEmployees { get; } = new List<InvEmployee>();
}
