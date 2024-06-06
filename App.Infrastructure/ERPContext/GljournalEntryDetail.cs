using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GljournalEntryDetail
{
    public int Id { get; set; }

    public int JournalEntryId { get; set; }

    public int? FinancialAccountId { get; set; }

    public string? FinancialCode { get; set; }

    public string? FinancialName { get; set; }

    public int? CostCenterId { get; set; }

    public double Credit { get; set; }

    public double Debit { get; set; }

    public string? DescriptionAr { get; set; }

    public string? DescriptionEn { get; set; }

    public bool IsCostSales { get; set; }

    public bool IsStoreFund { get; set; }

    public int? StoreFundId { get; set; }

    public int? DocType { get; set; }

    public virtual GlfinancialAccount? FinancialAccount { get; set; }

    public virtual GljournalEntry JournalEntry { get; set; } = null!;
}
