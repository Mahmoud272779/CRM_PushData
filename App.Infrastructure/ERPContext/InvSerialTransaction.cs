using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvSerialTransaction
{
    public int Id { get; set; }

    public string? SerialNumber { get; set; }

    public int ItemId { get; set; }

    public string? AddedInvoice { get; set; }

    public string? ExtractInvoice { get; set; }

    public int IndexOfSerialForAdd { get; set; }

    public int IndexOfSerialForExtract { get; set; }

    public int StoreId { get; set; }

    public bool IsAccridited { get; set; }

    public bool IsDeleted { get; set; }

    public int TransferStatus { get; set; }

    public virtual InvStpItemMaster Item { get; set; } = null!;

    public virtual InvStpStore Store { get; set; } = null!;
}
