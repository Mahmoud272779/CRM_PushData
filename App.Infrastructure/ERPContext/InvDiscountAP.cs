using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvDiscountAP
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string? DocNumber { get; set; }

    public string? PaperNumber { get; set; }

    public DateTime DocDate { get; set; }

    public bool IsCustomer { get; set; }

    public int PersonId { get; set; }

    public double Amount { get; set; }

    public string? Notes { get; set; }

    public double Creditor { get; set; }

    public double Debtor { get; set; }

    public int DocType { get; set; }

    public bool IsDeleted { get; set; }

    public string? Refrience { get; set; }

    public int BranchId { get; set; }

    public int? RecieptsId { get; set; }

    public virtual InvPerson Person { get; set; } = null!;
}
