using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvoiceDetail
{
    public int Id { get; set; }

    public int InvoiceId { get; set; }

    public int ItemId { get; set; }

    public int? UnitId { get; set; }

    public int? SizeId { get; set; }

    public double Quantity { get; set; }

    public double Price { get; set; }

    public double TotalWithSplitedDiscount { get; set; }

    public double TotalWithOutSplitedDiscount { get; set; }

    public DateTime? ExpireDate { get; set; }

    public int Signal { get; set; }

    public int ItemTypeId { get; set; }

    public double DiscountValue { get; set; }

    public double DiscountRatio { get; set; }

    public double VatRatio { get; set; }

    public double VatValue { get; set; }

    public double TransQuantity { get; set; }

    public double ReturnQuantity { get; set; }

    public int StatusOfTrans { get; set; }

    public double SplitedDiscountValue { get; set; }

    public double SplitedDiscountRatio { get; set; }

    public double AvgPrice { get; set; }

    public double Cost { get; set; }

    public double AutoDiscount { get; set; }

    public int PriceList { get; set; }

    public double MinimumPrice { get; set; }

    public double ConversionFactor { get; set; }

    public int IndexOfSerialNo { get; set; }

    public int IndexOfItem { get; set; }

    public string? BalanceBarcode { get; set; }

    public int? ParentItemId { get; set; }

    public double OtherAdditions { get; set; }

    public string? CodeOfflinePos { get; set; }

    public virtual InvoiceMaster Invoice { get; set; } = null!;

    public virtual InvStpItemMaster Item { get; set; } = null!;

    public virtual InvSize? Size { get; set; }

    public virtual InvStpUnit? Unit { get; set; }
}
