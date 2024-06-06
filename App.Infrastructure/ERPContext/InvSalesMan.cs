using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvSalesMan
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string ArabicName { get; set; } = null!;

    public string? LatinName { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public bool ApplyToCommissions { get; set; }

    public int? CommissionListId { get; set; }

    public bool CanDelete { get; set; }

    public string? Notes { get; set; }

    public int? FinancialAccountId { get; set; }

    public virtual InvCommissionList? CommissionList { get; set; }

    public virtual GlfinancialAccount? FinancialAccount { get; set; }

    public virtual ICollection<GlReciept> GlReciepts { get; } = new List<GlReciept>();

    public virtual ICollection<InvPerson> InvPeople { get; } = new List<InvPerson>();

    public virtual ICollection<InvoiceMaster> InvoiceMasters { get; } = new List<InvoiceMaster>();

    public virtual ICollection<OfferPriceMaster> OfferPriceMasters { get; } = new List<OfferPriceMaster>();

    public virtual ICollection<PosinvoiceSuspension> PosinvoiceSuspensions { get; } = new List<PosinvoiceSuspension>();

    public virtual ICollection<Glbranch> Branches { get; } = new List<Glbranch>();
}
