using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvCommissionList
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string ArabicName { get; set; } = null!;

    public string? LatinName { get; set; }

    public int Type { get; set; }

    public double? Ratio { get; set; }

    public double? Target { get; set; }

    public bool CanDelete { get; set; }

    public int BranchId { get; set; }

    public virtual ICollection<InvCommissionSlide> InvCommissionSlides { get; } = new List<InvCommissionSlide>();

    public virtual ICollection<InvSalesMan> InvSalesMen { get; } = new List<InvSalesMan>();
}
