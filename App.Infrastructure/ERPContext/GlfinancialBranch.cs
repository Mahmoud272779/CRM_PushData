using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GlfinancialBranch
{
    public int BranchId { get; set; }

    public int FinancialId { get; set; }

    public int? FinancialAccountId { get; set; }

    public virtual Glbranch Branch { get; set; } = null!;

    public virtual GlfinancialAccount? FinancialAccount { get; set; }
}
