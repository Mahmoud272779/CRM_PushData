using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class Glcurrency
{
    public int Id { get; set; }

    public string? LatinName { get; set; }

    public string? ArabicName { get; set; }

    public int Code { get; set; }

    public string? CoinsAr { get; set; }

    public string? CoinsEn { get; set; }

    public string? AbbrAr { get; set; }

    public string? AbbrEn { get; set; }

    public int Status { get; set; }

    public string? Notes { get; set; }

    public double Factor { get; set; }

    public bool IsDefault { get; set; }

    public bool CanDelete { get; set; }

    public string? LastUpdate { get; set; }

    public string? CurrancySymbol { get; set; }

    public string? BrowserName { get; set; }

    public virtual ICollection<GlfinancialAccount> GlfinancialAccounts { get; } = new List<GlfinancialAccount>();

    public virtual ICollection<GljournalEntry> GljournalEntries { get; } = new List<GljournalEntry>();
}
