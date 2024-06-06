using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GljournalEntryFile
{
    public int Id { get; set; }

    public string? File { get; set; }

    public int JournalEntryId { get; set; }

    public virtual GljournalEntry JournalEntry { get; set; } = null!;
}
