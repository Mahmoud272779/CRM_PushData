using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvoiceFile
{
    public int InvoiceFileId { get; set; }

    public int InvoiceId { get; set; }

    public string? FileLink { get; set; }

    public string? FileName { get; set; }

    public string? FileExtensions { get; set; }

    public virtual InvoiceMaster Invoice { get; set; } = null!;
}
