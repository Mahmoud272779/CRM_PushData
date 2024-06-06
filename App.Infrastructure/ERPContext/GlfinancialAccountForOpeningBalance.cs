using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GlfinancialAccountForOpeningBalance
{
    public int Id { get; set; }

    public double Credit { get; set; }

    public double Debit { get; set; }

    public string? Notes { get; set; }

    public string? AccountCode { get; set; }

    public DateTime Date { get; set; }

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
}
