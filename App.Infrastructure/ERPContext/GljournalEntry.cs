using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GljournalEntry
{
    public int Id { get; set; }

    public int Code { get; set; }

    public int CurrencyId { get; set; }

    public bool IsDeleted { get; set; }

    public double CreditTotal { get; set; }

    public double DebitTotal { get; set; }

    public DateTime? Ftdate { get; set; }

    public string? Notes { get; set; }

    public bool IsBlock { get; set; }

    public bool IsTransfer { get; set; }

    public bool IsAccredit { get; set; }

    public string? BrowserName { get; set; }

    public bool Auto { get; set; }

    public bool IsCompined { get; set; }

    public int? ReceiptsId { get; set; }

    public int? CompinedReceiptCode { get; set; }

    public int? InvoiceId { get; set; }

    public int? DocType { get; set; }

    public int BranchId { get; set; }

    public string? LastTransactionAction { get; set; }

    public string? AddTransactionUser { get; set; }

    public string? AddTransactionDate { get; set; }

    public string? LastTransactionUser { get; set; }

    public string? LastTransactionDate { get; set; }

    public string? DeleteTransactionUser { get; set; }

    public string? DeleteTransactionDate { get; set; }

    public string? LastTransactionUserAr { get; set; }

    public virtual Glcurrency Currency { get; set; } = null!;

    public virtual ICollection<GljournalEntryDetail> GljournalEntryDetails { get; } = new List<GljournalEntryDetail>();

    public virtual ICollection<GljournalEntryFile> GljournalEntryFiles { get; } = new List<GljournalEntryFile>();

    public virtual ICollection<GlfinancialAccount> FinancialAccounts { get; } = new List<GlfinancialAccount>();
}
