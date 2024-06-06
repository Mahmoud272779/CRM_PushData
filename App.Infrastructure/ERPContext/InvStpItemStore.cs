using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvStpItemStore
{
    public int ItemId { get; set; }

    public int StoreId { get; set; }

    public decimal DemandLimit { get; set; }

    public virtual InvStpItemMaster Item { get; set; } = null!;

    public virtual InvStpStore Store { get; set; } = null!;
}
