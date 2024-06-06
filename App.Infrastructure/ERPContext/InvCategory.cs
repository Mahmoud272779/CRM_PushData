using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvCategory
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string ArabicName { get; set; } = null!;

    public string? LatinName { get; set; }

    public double VatValue { get; set; }

    public string? Color { get; set; }

    public int Status { get; set; }

    public int UsedInSales { get; set; }

    public string? Notes { get; set; }

    public byte[]? Image { get; set; }

    public string? ImageName { get; set; }

    public string? ImagePath { get; set; }

    public bool CanDelete { get; set; }

    public DateTime Utime { get; set; }

    public virtual ICollection<InvStpItemMaster> InvStpItemMasters { get; } = new List<InvStpItemMaster>();
}
