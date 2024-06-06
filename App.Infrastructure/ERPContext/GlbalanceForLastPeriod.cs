using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GlbalanceForLastPeriod
{
    public int Id { get; set; }

    public double Balance { get; set; }

    public double TotalIncomeList { get; set; }

    public int BranchId { get; set; }

    public string? LastTransactionAction { get; set; }

    public string? AddTransactionUser { get; set; }

    public string? AddTransactionDate { get; set; }

    public string? LastTransactionUser { get; set; }

    public string? LastTransactionDate { get; set; }

    public string? DeleteTransactionUser { get; set; }

    public string? DeleteTransactionDate { get; set; }

    public string? LastTransactionUserAr { get; set; }
}
