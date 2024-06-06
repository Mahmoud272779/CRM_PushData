using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvCommissionSlide
{
    public int Id { get; set; }

    public int CommissionId { get; set; }

    public int SlideNo { get; set; }

    public double SlideFrom { get; set; }

    public double SlideTo { get; set; }

    public double Ratio { get; set; }

    public double Value { get; set; }

    public virtual InvCommissionList Commission { get; set; } = null!;
}
