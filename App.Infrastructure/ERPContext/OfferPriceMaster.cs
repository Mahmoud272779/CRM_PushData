using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class OfferPriceMaster
{
    public int InvoiceId { get; set; }

    public int BranchId { get; set; }

    public string? InvoiceType { get; set; }

    public int Code { get; set; }

    public double Serialize { get; set; }

    public string? ParentInvoiceCode { get; set; }

    public bool IsDeleted { get; set; }

    public string? BookIndex { get; set; }

    public DateTime InvoiceDate { get; set; }

    public int StoreId { get; set; }

    public int TransferStatus { get; set; }

    public double TotalPrice { get; set; }

    public string? Notes { get; set; }

    public string? TransferNotesAr { get; set; }

    public string? TransferNotesEn { get; set; }

    public int InvoiceTypeId { get; set; }

    public int InvoiceSubTypesId { get; set; }

    public string? BrowserName { get; set; }

    public bool IsAccredite { get; set; }

    public int EmployeeId { get; set; }

    public int? PersonId { get; set; }

    public double TotalDiscountValue { get; set; }

    public double TotalDiscountRatio { get; set; }

    public double Net { get; set; }

    public double Paid { get; set; }

    public double Remain { get; set; }

    public double VirualPaid { get; set; }

    public double TotalAfterDiscount { get; set; }

    public double TotalVat { get; set; }

    public bool ApplyVat { get; set; }

    public bool PriceWithVat { get; set; }

    public int DiscountType { get; set; }

    public int PaymentType { get; set; }

    public bool ActiveDiscount { get; set; }

    public bool IsReturn { get; set; }

    public int? SalesManId { get; set; }

    public int? PriceListId { get; set; }

    public string? InvoiceTransferType { get; set; }

    public int RoundNumber { get; set; }

    public virtual Glbranch Branch { get; set; } = null!;

    public virtual InvEmployee Employee { get; set; } = null!;

    public virtual ICollection<OfferPriceDetail> OfferPriceDetails { get; } = new List<OfferPriceDetail>();

    public virtual InvPerson? Person { get; set; }

    public virtual InvSalesMan? SalesMan { get; set; }

    public virtual InvStpStore Store { get; set; } = null!;
}
