using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvPurchaseAdditionalCostsRelation
{
    public int PurchaseAdditionalCostsId { get; set; }

    public int InvoiceId { get; set; }

    public int AddtionalCostId { get; set; }

    public double Amount { get; set; }

    public double Total { get; set; }

    public string? CodeOfflinePos { get; set; }

    public virtual InvPurchasesAdditionalCost AddtionalCost { get; set; } = null!;

    public virtual InvoiceMaster Invoice { get; set; } = null!;
}
