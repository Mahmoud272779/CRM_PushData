using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvPurchasesAdditionalCost
{
    public int PurchasesAdditionalCostsId { get; set; }

    public int Code { get; set; }

    public string ArabicName { get; set; } = null!;

    public string? LatinName { get; set; }

    public int Status { get; set; }

    public string? Notes { get; set; }

    public int AdditionalType { get; set; }

    public DateTime Utime { get; set; }

    public virtual ICollection<InvPurchaseAdditionalCostsRelation> InvPurchaseAdditionalCostsRelations { get; } = new List<InvPurchaseAdditionalCostsRelation>();
}
