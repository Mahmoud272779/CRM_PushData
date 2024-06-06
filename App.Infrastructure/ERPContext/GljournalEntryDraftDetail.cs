using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GljournalEntryDraftDetail
{
    public int Id { get; set; }

    public int JournalEntryDraftId { get; set; }

    public int? FinancialAccountId { get; set; }

    public int? CostCenterId { get; set; }

    public double Credit { get; set; }

    public double Debit { get; set; }

    public string? DescriptionAr { get; set; }

    public string? DescriptionEn { get; set; }

    public virtual GljournalEntryDraft JournalEntryDraft { get; set; } = null!;
}
