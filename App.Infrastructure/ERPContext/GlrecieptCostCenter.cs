using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GlrecieptCostCenter
{
    public int Id { get; set; }

    public int CostCenterId { get; set; }

    public int SupportId { get; set; }

    public string? CostCenteCode { get; set; }

    public string? CostCenteName { get; set; }

    public double Percentage { get; set; }

    public double Number { get; set; }

    public virtual GlcostCenter CostCenter { get; set; } = null!;

    public virtual GlReciept Support { get; set; } = null!;
}
