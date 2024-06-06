using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class OtherAuthority
{
    public int Id { get; set; }

    public string? LatinName { get; set; }

    public string? ArabicName { get; set; }

    public int Code { get; set; }

    public int? FinancialAccountId { get; set; }

    public int Status { get; set; }

    public string? Notes { get; set; }

    public bool CanDelete { get; set; }

    public int BranchId { get; set; }

    public virtual Glbranch Branch { get; set; } = null!;

    public virtual GlfinancialAccount? FinancialAccount { get; set; }

    public virtual ICollection<GlReciept> GlReciepts { get; } = new List<GlReciept>();
}
