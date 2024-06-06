using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvSize
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string ArabicName { get; set; } = null!;

    public string? LatinName { get; set; }

    public int Status { get; set; }

    public string? Notes { get; set; }

    public bool CanDelete { get; set; }

    public virtual ICollection<InvStpItemColorSize> InvStpItemColorSizes { get; } = new List<InvStpItemColorSize>();

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; } = new List<InvoiceDetail>();

    public virtual ICollection<OfferPriceDetail> OfferPriceDetails { get; } = new List<OfferPriceDetail>();

    public virtual ICollection<PosinvSuspensionDetail> PosinvSuspensionDetails { get; } = new List<PosinvSuspensionDetail>();
}
