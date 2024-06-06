using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GlfinancialSetting
{
    public int Id { get; set; }

    public bool IsAssumption { get; set; }

    public int FinancialAccountId { get; set; }

    public bool UseFinancialAccount { get; set; }

    public bool AddUnderFinancialAccount { get; set; }

    public bool IsBanks { get; set; }

    public bool IsOthorAuthorities { get; set; }

    public bool IsTreasuries { get; set; }

    public bool IsCustomers { get; set; }

    public bool IsSuppliers { get; set; }

    public bool IsSalesRepresentatives { get; set; }

    public int BranchId { get; set; }

    public string? LastTransactionAction { get; set; }

    public string? AddTransactionUser { get; set; }

    public string? AddTransactionDate { get; set; }

    public string? LastTransactionUser { get; set; }

    public string? LastTransactionDate { get; set; }

    public string? DeleteTransactionUser { get; set; }

    public string? DeleteTransactionDate { get; set; }

    public string? LastTransactionUserAr { get; set; }

    public virtual GlfinancialAccount FinancialAccount { get; set; } = null!;
}
