using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GlfinancialAccountHistory
{
    public int Id { get; set; }

    public int CurrencyId { get; set; }

    public string? AccountCode { get; set; }

    public int MainCode { get; set; }

    public int SubCode { get; set; }

    public int Status { get; set; }

    public int FaNature { get; set; }

    public int FinalAccount { get; set; }

    public string? LastAction { get; set; }

    public DateTime LastDate { get; set; }

    public double Credit { get; set; }

    public double Debit { get; set; }

    public string? Notes { get; set; }

    public int? ParentId { get; set; }

    public int? HasCostCenter { get; set; }

    public string? BrowserName { get; set; }

    public int EmployeesId { get; set; }

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

    public virtual InvEmployee Employees { get; set; } = null!;
}
