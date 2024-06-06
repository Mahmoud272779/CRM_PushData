using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvFundsBanksSafesDetail
{
    public int Id { get; set; }

    public int DocumentId { get; set; }

    public int PaymentId { get; set; }

    public double Debtor { get; set; }

    public double Creditor { get; set; }

    public virtual InvFundsBanksSafesMaster Document { get; set; } = null!;
}
