using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class Glbranch
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string? LatinName { get; set; }

    public string? ArabicName { get; set; }

    public string? AddressEn { get; set; }

    public string? AddressAr { get; set; }

    public string? Fax { get; set; }

    public string? Phone { get; set; }

    public int Status { get; set; }

    public string? Notes { get; set; }

    public int? ManagerId { get; set; }

    public string? ManagerPhone { get; set; }

    public string? BrowserName { get; set; }

    public bool CanDelete { get; set; }

    public DateTime Utime { get; set; }

    public virtual ICollection<GlfinancialBranch> GlfinancialBranches { get; } = new List<GlfinancialBranch>();

    public virtual ICollection<GlintegrationSetting> GlintegrationSettings { get; } = new List<GlintegrationSetting>();

    public virtual ICollection<GlpurchasesAndSalesSetting> GlpurchasesAndSalesSettings { get; } = new List<GlpurchasesAndSalesSetting>();

    public virtual ICollection<Glsafe> Glsaves { get; } = new List<Glsafe>();

    public virtual ICollection<InvEmployeesBranch> InvEmployeesBranches { get; } = new List<InvEmployeesBranch>();

    public virtual ICollection<InvStpStore> InvStpStores { get; } = new List<InvStpStore>();

    public virtual ICollection<InvoiceMaster> InvoiceMasters { get; } = new List<InvoiceMaster>();

    public virtual ICollection<OfferPriceMaster> OfferPriceMasters { get; } = new List<OfferPriceMaster>();

    public virtual ICollection<OtherAuthority> OtherAuthorities { get; } = new List<OtherAuthority>();

    public virtual ICollection<PosinvoiceSuspension> PosinvoiceSuspensions { get; } = new List<PosinvoiceSuspension>();

    public virtual ICollection<SystemHistoryLog> SystemHistoryLogs { get; } = new List<SystemHistoryLog>();

    public virtual ICollection<UserBranch> UserBranches { get; } = new List<UserBranch>();

    public virtual ICollection<Glbank> Banks { get; } = new List<Glbank>();

    public virtual ICollection<GlfinancialAccount> FinancialAccounts { get; } = new List<GlfinancialAccount>();

    public virtual ICollection<InvPerson> People { get; } = new List<InvPerson>();

    public virtual ICollection<InvSalesMan> SalesMen { get; } = new List<InvSalesMan>();

    public virtual ICollection<InvStpStore> Stores { get; } = new List<InvStpStore>();
}
