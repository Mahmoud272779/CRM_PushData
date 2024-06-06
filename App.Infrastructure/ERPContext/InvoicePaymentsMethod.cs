using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvoicePaymentsMethod
{
    public int InvoicePaymentsMethodId { get; set; }

    public int PaymentMethodId { get; set; }

    public int InvoiceId { get; set; }

    public double Value { get; set; }

    public string? Cheque { get; set; }

    public int BranchId { get; set; }

    public string? CodeOfflinePos { get; set; }

    public virtual InvoiceMaster Invoice { get; set; } = null!;

    public virtual InvPaymentMethod PaymentMethod { get; set; } = null!;
}
