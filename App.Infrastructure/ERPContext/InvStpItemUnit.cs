using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvStpItemUnit
{
    public int ItemId { get; set; }

    public int UnitId { get; set; }

    public double ConversionFactor { get; set; }

    public double PurchasePrice { get; set; }

    public double SalePrice1 { get; set; }

    public double SalePrice2 { get; set; }

    public double SalePrice3 { get; set; }

    public double SalePrice4 { get; set; }

    public string? Barcode { get; set; }

    public bool WillDelete { get; set; }

    public virtual ICollection<InvStpItemColorSize> InvStpItemColorSizes { get; } = new List<InvStpItemColorSize>();

    public virtual InvStpItemMaster Item { get; set; } = null!;

    public virtual InvStpUnit Unit { get; set; } = null!;
}
