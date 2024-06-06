using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvPersonLastPrice
{
    public int Id { get; set; }

    public int PersonId { get; set; }

    public int ItemId { get; set; }

    public int UnitId { get; set; }

    public int InvoiceTypeId { get; set; }

    public double Price { get; set; }
}
