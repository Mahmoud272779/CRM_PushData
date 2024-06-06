using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class Glsafe
{
    public int Id { get; set; }

    public string? LatinName { get; set; }

    public string? ArabicName { get; set; }

    public int Code { get; set; }

    public int Status { get; set; }

    public string? Notes { get; set; }

    public int? FinancialAccountId { get; set; }

    public string? BrowserName { get; set; }

    public bool CanDelete { get; set; }

    public int BranchId { get; set; }

    public virtual Glbranch Branch { get; set; } = null!;

    public virtual GlfinancialAccount? FinancialAccount { get; set; }

    public virtual ICollection<GlReciept> GlReciepts { get; } = new List<GlReciept>();

    public virtual ICollection<InvFundsBanksSafesMaster> InvFundsBanksSafesMasters { get; } = new List<InvFundsBanksSafesMaster>();

    public virtual ICollection<InvPaymentMethod> InvPaymentMethods { get; } = new List<InvPaymentMethod>();

    public virtual ICollection<OtherSettingsSafe> OtherSettingsSaves { get; } = new List<OtherSettingsSafe>();
}
