using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvFundsCustomerSupplier
{
    public int Id { get; set; }

    public int PersonId { get; set; }

    public double Credit { get; set; }

    public double Debit { get; set; }

    public string? LastTransactionAction { get; set; }

    public string? AddTransactionUser { get; set; }

    public string? AddTransactionDate { get; set; }

    public string? LastTransactionUser { get; set; }

    public string? LastTransactionDate { get; set; }

    public string? DeleteTransactionUser { get; set; }

    public string? DeleteTransactionDate { get; set; }

    public virtual InvPerson Person { get; set; } = null!;
}
