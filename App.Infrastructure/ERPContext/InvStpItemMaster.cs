using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvStpItemMaster
{
    public int Id { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? NationalBarcode { get; set; }

    public int TypeId { get; set; }

    public bool UsedInSales { get; set; }

    public int? DepositeUnit { get; set; }

    public int? WithdrawUnit { get; set; }

    public int? ReportUnit { get; set; }

    public double Vat { get; set; }

    public bool ApplyVat { get; set; }

    public string? Model { get; set; }

    public int? DefaultStoreId { get; set; }

    public string? Description { get; set; }

    public string? LatinName { get; set; }

    public string ArabicName { get; set; } = null!;

    public int GroupId { get; set; }

    public int Status { get; set; }

    public byte[]? Image { get; set; }

    public string? ImageName { get; set; }

    public string? ImagePath { get; set; }

    public int BranchId { get; set; }

    public bool CanDelete { get; set; }

    public DateTime Utime { get; set; }

    public virtual InvStorePlace? DefaultStore { get; set; }

    public virtual InvCategory Group { get; set; } = null!;

    public virtual ICollection<InvSerialTransaction> InvSerialTransactions { get; } = new List<InvSerialTransaction>();

    public virtual ICollection<InvStpItemCardPart> InvStpItemCardPartItems { get; } = new List<InvStpItemCardPart>();

    public virtual ICollection<InvStpItemCardPart> InvStpItemCardPartParts { get; } = new List<InvStpItemCardPart>();

    public virtual ICollection<InvStpItemCardSerial> InvStpItemCardSerials { get; } = new List<InvStpItemCardSerial>();

    public virtual ICollection<InvStpItemColorSize> InvStpItemColorSizes { get; } = new List<InvStpItemColorSize>();

    public virtual ICollection<InvStpItemStore> InvStpItemStores { get; } = new List<InvStpItemStore>();

    public virtual ICollection<InvStpItemUnit> InvStpItemUnits { get; } = new List<InvStpItemUnit>();

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; } = new List<InvoiceDetail>();

    public virtual ICollection<OfferPriceDetail> OfferPriceDetails { get; } = new List<OfferPriceDetail>();

    public virtual ICollection<PosinvSuspensionDetail> PosinvSuspensionDetails { get; } = new List<PosinvSuspensionDetail>();
}
