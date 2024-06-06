using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class Glbank
{
    public int Id { get; set; }

    public string? LatinName { get; set; }

    public string? ArabicName { get; set; }

    public int Code { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? AccountNumber { get; set; }

    public int? FinancialAccountId { get; set; }

    public int Status { get; set; }

    public string? ArabicAddress { get; set; }

    public string? LatinAddress { get; set; }

    public string? Notes { get; set; }

    public string? BrowserName { get; set; }

    public string? Website { get; set; }

    public bool CanDelete { get; set; }

    public virtual GlfinancialAccount? FinancialAccount { get; set; }

    public virtual ICollection<GlReciept> GlReciepts { get; } = new List<GlReciept>();

    public virtual ICollection<InvFundsBanksSafesMaster> InvFundsBanksSafesMasters { get; } = new List<InvFundsBanksSafesMaster>();

    public virtual ICollection<InvPaymentMethod> InvPaymentMethods { get; } = new List<InvPaymentMethod>();

    public virtual ICollection<OtherSettingsBank> OtherSettingsBanks { get; } = new List<OtherSettingsBank>();

    public virtual ICollection<Glbranch> Branches { get; } = new List<Glbranch>();
}
