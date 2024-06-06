using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvPerson
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string ArabicName { get; set; } = null!;

    public string? LatinName { get; set; }

    public int Type { get; set; }

    public int Status { get; set; }

    public int? SalesManId { get; set; }

    public string? ResponsibleAr { get; set; }

    public string? ResponsibleEn { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? TaxNumber { get; set; }

    public string? AddressAr { get; set; }

    public string? AddressEn { get; set; }

    public double? CreditLimit { get; set; }

    public int? CreditPeriod { get; set; }

    public double? DiscountRatio { get; set; }

    public int? SalesPriceId { get; set; }

    public int? InvEmployeesId { get; set; }

    public int? LessSalesPriceId { get; set; }

    public bool IsCustomer { get; set; }

    public bool IsSupplier { get; set; }

    public bool CanDelete { get; set; }

    public bool AddToAnotherList { get; set; }

    public DateTime Utime { get; set; }

    public string? CodeT { get; set; }

    public string? BuildingNumber { get; set; }

    public string? StreetName { get; set; }

    public string? Neighborhood { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? PostalNumber { get; set; }

    public int? FinancialAccountId { get; set; }

    public virtual GlfinancialAccount? FinancialAccount { get; set; }

    public virtual ICollection<GlReciept> GlReciepts { get; } = new List<GlReciept>();

    public virtual ICollection<InvDiscountAP> InvDiscountAPs { get; } = new List<InvDiscountAP>();

    public virtual InvEmployee? InvEmployees { get; set; }

    public virtual InvFundsCustomerSupplier? InvFundsCustomerSupplier { get; set; }

    public virtual ICollection<InvoiceMaster> InvoiceMasters { get; } = new List<InvoiceMaster>();

    public virtual ICollection<OfferPriceMaster> OfferPriceMasters { get; } = new List<OfferPriceMaster>();

    public virtual ICollection<PosinvoiceSuspension> PosinvoiceSuspensions { get; } = new List<PosinvoiceSuspension>();

    public virtual InvSalesMan? SalesMan { get; set; }

    public virtual ICollection<Glbranch> Branches { get; } = new List<Glbranch>();
}
