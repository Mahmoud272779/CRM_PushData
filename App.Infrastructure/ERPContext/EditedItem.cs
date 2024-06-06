using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class EditedItem
{
    public int ItemId { get; set; }

    public int SizeId { get; set; }

    public int BranchId { get; set; }

    public int Type { get; set; }

    public double Serialize { get; set; }
}
