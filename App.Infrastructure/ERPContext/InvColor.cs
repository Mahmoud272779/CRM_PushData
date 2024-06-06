using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvColor
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string ArabicName { get; set; } = null!;

    public string? LatinName { get; set; }

    public string? Color { get; set; }

    public int Status { get; set; }

    public string? Notes { get; set; }

    public bool CanDelete { get; set; }

    public virtual ICollection<InvStpItemColorSize> InvStpItemColorSizes { get; } = new List<InvStpItemColorSize>();
}
