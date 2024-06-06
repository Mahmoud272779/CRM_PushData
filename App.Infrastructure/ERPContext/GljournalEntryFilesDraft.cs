using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GljournalEntryFilesDraft
{
    public int Id { get; set; }

    public string? File { get; set; }

    public int JournalEntryDraftId { get; set; }

    public virtual GljournalEntryDraft JournalEntryDraft { get; set; } = null!;
}
