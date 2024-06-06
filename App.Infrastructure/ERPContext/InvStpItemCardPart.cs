using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvStpItemCardPart
{
    public int ItemId { get; set; }

    public int PartId { get; set; }

    public double Quantity { get; set; }

    public int UnitId { get; set; }

    public virtual InvStpItemMaster Item { get; set; } = null!;

    public virtual InvStpItemMaster Part { get; set; } = null!;

    public virtual InvStpUnit Unit { get; set; } = null!;
}
