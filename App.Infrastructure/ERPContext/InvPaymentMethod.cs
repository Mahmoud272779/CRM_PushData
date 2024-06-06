using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvPaymentMethod
{
    public int PaymentMethodId { get; set; }

    public int Code { get; set; }

    public string ArabicName { get; set; } = null!;

    public string? LatinName { get; set; }

    public int? SafeId { get; set; }

    public int? BankId { get; set; }

    public int Status { get; set; }

    public bool CanDelete { get; set; }

    public DateTime Utime { get; set; }

    public virtual Glbank? Bank { get; set; }

    public virtual ICollection<GlReciept> GlReciepts { get; } = new List<GlReciept>();

    public virtual ICollection<InvoicePaymentsMethod> InvoicePaymentsMethods { get; } = new List<InvoicePaymentsMethod>();

    public virtual Glsafe? Safe { get; set; }
}
