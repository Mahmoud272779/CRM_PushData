using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvBarcodeTemplate
{
    public int BarcodeId { get; set; }

    public int Code { get; set; }

    public string ArabicName { get; set; } = null!;

    public string? LatinName { get; set; }

    public bool IsDefault { get; set; }

    public bool CanDelete { get; set; }

    public string? BrowserName { get; set; }

    public virtual ICollection<InvBarcodeItem> InvBarcodeItems { get; } = new List<InvBarcodeItem>();
}
