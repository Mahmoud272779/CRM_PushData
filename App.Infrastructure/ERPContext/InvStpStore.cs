using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvStpStore
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string ArabicName { get; set; } = null!;

    public string? LatinName { get; set; }

    public int Status { get; set; }

    public string? Fax { get; set; }

    public string? Phone { get; set; }

    public string? AddressAr { get; set; }

    public string? AddressEn { get; set; }

    public string? Notes { get; set; }

    public bool CanDelete { get; set; }

    public DateTime Utime { get; set; }

    public int? GlbranchId { get; set; }

    public virtual Glbranch? Glbranch { get; set; }

    public virtual ICollection<InvSerialTransaction> InvSerialTransactions { get; } = new List<InvSerialTransaction>();

    public virtual ICollection<InvStpItemStore> InvStpItemStores { get; } = new List<InvStpItemStore>();

    public virtual ICollection<InvoiceMaster> InvoiceMasterStoreIdToNavigations { get; } = new List<InvoiceMaster>();

    public virtual ICollection<InvoiceMaster> InvoiceMasterStores { get; } = new List<InvoiceMaster>();

    public virtual ICollection<OfferPriceMaster> OfferPriceMasters { get; } = new List<OfferPriceMaster>();

    public virtual ICollection<OtherSettingsStore> OtherSettingsStores { get; } = new List<OtherSettingsStore>();

    public virtual ICollection<PosinvoiceSuspension> PosinvoiceSuspensions { get; } = new List<PosinvoiceSuspension>();

    public virtual ICollection<Glbranch> Branches { get; } = new List<Glbranch>();
}
