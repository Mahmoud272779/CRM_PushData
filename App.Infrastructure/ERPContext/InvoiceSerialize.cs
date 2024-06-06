using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvoiceSerialize
{
    public int InvoiceSerializeId { get; set; }

    public double Serialize { get; set; }

    public int InvoiceCode { get; set; }

    public int InvoiceTypeId { get; set; }

    public int BranchId { get; set; }
}
