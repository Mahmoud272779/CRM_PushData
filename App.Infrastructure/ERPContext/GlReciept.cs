using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GlReciept
{
    public int Id { get; set; }

    public int? SafeId { get; set; }

    public int? BankId { get; set; }

    public int? EntryFundId { get; set; }

    public int Code { get; set; }

    public string? PaperNumber { get; set; }

    public DateTime RecieptDate { get; set; }

    public string? Notes { get; set; }

    public double Amount { get; set; }

    public int Authority { get; set; }

    public int PaymentMethodId { get; set; }

    public string? ChequeNumber { get; set; }

    public string? ChequeBankName { get; set; }

    public DateTime ChequeDate { get; set; }

    public int RecieptTypeId { get; set; }

    public string? RecieptType { get; set; }

    public int Signal { get; set; }

    public int? ParentId { get; set; }

    public int? ParentTypeId { get; set; }

    public double Serialize { get; set; }

    public int BranchId { get; set; }

    public int UserId { get; set; }

    public bool IsAccredit { get; set; }

    public bool IsCompined { get; set; }

    public int? CompinedParentId { get; set; }

    public string? NoteAr { get; set; }

    public string? NoteEn { get; set; }

    public double Creditor { get; set; }

    public double Debtor { get; set; }

    public DateTime CreationDate { get; set; }

    public int OtherSalesManId { get; set; }

    public int? FinancialAccountId { get; set; }

    public bool IsIncludeVat { get; set; }

    public int BenefitId { get; set; }

    public int? PersonId { get; set; }

    public int? SalesManId { get; set; }

    public int? OtherAuthorityId { get; set; }

    public bool IsBlock { get; set; }

    public bool Deferre { get; set; }

    public string? RectypeWithPayment { get; set; }

    public int? IsPartialPaid { get; set; }

    public virtual Glbank? Bank { get; set; }

    public virtual GlfinancialAccount? FinancialAccount { get; set; }

    public virtual ICollection<GlrecieptCostCenter> GlrecieptCostCenters { get; } = new List<GlrecieptCostCenter>();

    public virtual ICollection<GlrecieptFile> GlrecieptFiles { get; } = new List<GlrecieptFile>();

    public virtual OtherAuthority? OtherAuthority { get; set; }

    public virtual InvPaymentMethod PaymentMethod { get; set; } = null!;

    public virtual InvPerson? Person { get; set; }

    public virtual Glsafe? Safe { get; set; }

    public virtual InvSalesMan? SalesMan { get; set; }
}
