using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvEmployee
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string ArabicName { get; set; } = null!;

    public string? LatinName { get; set; }

    public int Status { get; set; }

    public string? Notes { get; set; }

    public string? ImagePath { get; set; }

    public int JobId { get; set; }

    public int? FinancialAccountId { get; set; }

    public bool CanDelete { get; set; }

    public string? UserId { get; set; }

    public DateTime Utime { get; set; }

    public virtual ICollection<ChatGroupMember> ChatGroupMembers { get; } = new List<ChatGroupMember>();

    public virtual ICollection<ChatGroup> ChatGroups { get; } = new List<ChatGroup>();

    public virtual ICollection<ChatMessage> ChatMessageFroms { get; } = new List<ChatMessage>();

    public virtual ICollection<ChatMessage> ChatMessageTos { get; } = new List<ChatMessage>();

    public virtual GlfinancialAccount? FinancialAccount { get; set; }

    public virtual ICollection<GlbanksHistory> GlbanksHistories { get; } = new List<GlbanksHistory>();

    public virtual ICollection<GlbranchHistory> GlbranchHistories { get; } = new List<GlbranchHistory>();

    public virtual ICollection<GlcostCenterHistory> GlcostCenterHistories { get; } = new List<GlcostCenterHistory>();

    public virtual ICollection<GlcurrencyHistory> GlcurrencyHistories { get; } = new List<GlcurrencyHistory>();

    public virtual ICollection<GlfinancialAccountHistory> GlfinancialAccountHistories { get; } = new List<GlfinancialAccountHistory>();

    public virtual ICollection<GlotherAuthoritiesHistory> GlotherAuthoritiesHistories { get; } = new List<GlotherAuthoritiesHistory>();

    public virtual ICollection<GlrecHistory> GlrecHistories { get; } = new List<GlrecHistory>();

    public virtual ICollection<GlrecieptsHistory> GlrecieptsHistories { get; } = new List<GlrecieptsHistory>();

    public virtual ICollection<GlsafeHistory> GlsafeHistories { get; } = new List<GlsafeHistory>();

    public virtual ICollection<InvBarcodeHistory> InvBarcodeHistories { get; } = new List<InvBarcodeHistory>();

    public virtual ICollection<InvCategoriesHistory> InvCategoriesHistories { get; } = new List<InvCategoriesHistory>();

    public virtual ICollection<InvColorsHistory> InvColorsHistories { get; } = new List<InvColorsHistory>();

    public virtual ICollection<InvCommissionListHistory> InvCommissionListHistories { get; } = new List<InvCommissionListHistory>();

    public virtual ICollection<InvDiscountAPHistory> InvDiscountAPHistories { get; } = new List<InvDiscountAPHistory>();

    public virtual ICollection<InvEmployeesBranch> InvEmployeesBranches { get; } = new List<InvEmployeesBranch>();

    public virtual ICollection<InvEmployeesHistory> InvEmployeesHistories { get; } = new List<InvEmployeesHistory>();

    public virtual ICollection<InvFundsBanksSafesHistory> InvFundsBanksSafesHistories { get; } = new List<InvFundsBanksSafesHistory>();

    public virtual ICollection<InvJobsHistory> InvJobsHistories { get; } = new List<InvJobsHistory>();

    public virtual ICollection<InvPaymentMethodsHistory> InvPaymentMethodsHistories { get; } = new List<InvPaymentMethodsHistory>();

    public virtual ICollection<InvPerson> InvPeople { get; } = new List<InvPerson>();

    public virtual ICollection<InvPersonsHistory> InvPersonsHistories { get; } = new List<InvPersonsHistory>();

    public virtual ICollection<InvPurchasesAdditionalCostsHistory> InvPurchasesAdditionalCostsHistories { get; } = new List<InvPurchasesAdditionalCostsHistory>();

    public virtual ICollection<InvSalesManHistory> InvSalesManHistories { get; } = new List<InvSalesManHistory>();

    public virtual ICollection<InvSizesHistory> InvSizesHistories { get; } = new List<InvSizesHistory>();

    public virtual ICollection<InvStorePlacesHistory> InvStorePlacesHistories { get; } = new List<InvStorePlacesHistory>();

    public virtual ICollection<InvStoresHistory> InvStoresHistories { get; } = new List<InvStoresHistory>();

    public virtual ICollection<InvStpItemCardHistory> InvStpItemCardHistories { get; } = new List<InvStpItemCardHistory>();

    public virtual ICollection<InvUnitsHistory> InvUnitsHistories { get; } = new List<InvUnitsHistory>();

    public virtual ICollection<InvoiceMasterHistory> InvoiceMasterHistories { get; } = new List<InvoiceMasterHistory>();

    public virtual ICollection<InvoiceMaster> InvoiceMasters { get; } = new List<InvoiceMaster>();

    public virtual InvJob Job { get; set; } = null!;

    public virtual ICollection<NotificationSeen> NotificationSeens { get; } = new List<NotificationSeen>();

    public virtual ICollection<NotificationsMaster> NotificationsMasterInsertedBies { get; } = new List<NotificationsMaster>();

    public virtual ICollection<NotificationsMaster> NotificationsMasterSpecialUsers { get; } = new List<NotificationsMaster>();

    public virtual ICollection<OfferPriceMaster> OfferPriceMasters { get; } = new List<OfferPriceMaster>();

    public virtual ICollection<PosinvoiceSuspension> PosinvoiceSuspensions { get; } = new List<PosinvoiceSuspension>();

    public virtual ICollection<Possession> PossessionEmployees { get; } = new List<Possession>();

    public virtual ICollection<PossessionHistory> PossessionHistories { get; } = new List<PossessionHistory>();

    public virtual ICollection<Possession> PossessionSessionClosedBies { get; } = new List<Possession>();

    public virtual ICollection<SignalR> SignalRs { get; } = new List<SignalR>();

    public virtual ICollection<SystemHistoryLog> SystemHistoryLogs { get; } = new List<SystemHistoryLog>();

    public virtual ICollection<UserAccount> UserAccounts { get; } = new List<UserAccount>();
}
