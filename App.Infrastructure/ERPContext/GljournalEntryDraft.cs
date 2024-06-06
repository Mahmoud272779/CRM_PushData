using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GljournalEntryDraft
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string? Name { get; set; }

    public int CurrencyId { get; set; }

    public double CreditTotal { get; set; }

    public double DebitTotal { get; set; }

    public DateTime? Ftdate { get; set; }

    public string? Notes { get; set; }

    public bool IsBlock { get; set; }

    public int BranchId { get; set; }

    public string? LastTransactionAction { get; set; }

    public string? AddTransactionUser { get; set; }

    public string? AddTransactionDate { get; set; }

    public string? LastTransactionUser { get; set; }

    public string? LastTransactionDate { get; set; }

    public string? DeleteTransactionUser { get; set; }

    public string? DeleteTransactionDate { get; set; }

    public string? LastTransactionUserAr { get; set; }

    public virtual ICollection<GljournalEntryDraftDetail> GljournalEntryDraftDetails { get; } = new List<GljournalEntryDraftDetail>();

    public virtual ICollection<GljournalEntryFilesDraft> GljournalEntryFilesDrafts { get; } = new List<GljournalEntryFilesDraft>();
}
