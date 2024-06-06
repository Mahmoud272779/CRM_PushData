using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GlcostCenter
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public double InitialBalance { get; set; }

    public int CcNature { get; set; }

    public int Type { get; set; }

    public string? Notes { get; set; }

    public int? ParentId { get; set; }

    public string? BrowserName { get; set; }

    public string? AutoCode { get; set; }

    public int BranchId { get; set; }

    public string? LastTransactionAction { get; set; }

    public string? AddTransactionUser { get; set; }

    public string? AddTransactionDate { get; set; }

    public string? LastTransactionUser { get; set; }

    public string? LastTransactionDate { get; set; }

    public string? DeleteTransactionUser { get; set; }

    public string? DeleteTransactionDate { get; set; }

    public string? LastTransactionUserAr { get; set; }

    public string? LatinName { get; set; }

    public string? ArabicName { get; set; }

    public virtual ICollection<GlrecieptCostCenter> GlrecieptCostCenters { get; } = new List<GlrecieptCostCenter>();

    public virtual ICollection<GlcostCenter> InverseParent { get; } = new List<GlcostCenter>();

    public virtual GlcostCenter? Parent { get; set; }

    public virtual ICollection<GlfinancialAccount> FinancialAccounts { get; } = new List<GlfinancialAccount>();
}
