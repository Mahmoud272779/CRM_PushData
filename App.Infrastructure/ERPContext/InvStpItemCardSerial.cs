using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvStpItemCardSerial
{
    public int ItemId { get; set; }

    public string SerialNo { get; set; } = null!;

    public virtual InvStpItemMaster Item { get; set; } = null!;
}
