using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class OtherSetting
{
    public int Id { get; set; }

    public bool PosAddDiscount { get; set; }

    public bool PosAllowCreditSales { get; set; }

    public bool PosEditOtherPersonsInv { get; set; }

    public bool PosShowOtherPersonsInv { get; set; }

    public bool PosShowReportsOfOtherPersons { get; set; }

    public bool AllowCloseCloudPossession { get; set; }

    public bool CanShowAllPossessions { get; set; }

    public bool PosCashPayment { get; set; }

    public bool PosNetPayment { get; set; }

    public bool PosOtherPayment { get; set; }

    public bool SalesAddDiscount { get; set; }

    public bool SalesAllowCreditSales { get; set; }

    public bool SalesEditOtherPersonsInv { get; set; }

    public bool SalesShowOtherPersonsInv { get; set; }

    public bool SalesShowReportsOfOtherPersons { get; set; }

    public bool SalesCashPayment { get; set; }

    public bool SalesNetPayment { get; set; }

    public bool SalesOtherPayment { get; set; }

    public bool PurchasesAddDiscount { get; set; }

    public bool PurchasesAllowCreditSales { get; set; }

    public bool PurchasesEditOtherPersonsInv { get; set; }

    public bool PurchasesShowOtherPersonsInv { get; set; }

    public bool PurchasesShowReportsOfOtherPersons { get; set; }

    public bool PurchasesCashPayment { get; set; }

    public bool PurchasesNetPayment { get; set; }

    public bool PurchasesOtherPayment { get; set; }

    public bool ShowHistory { get; set; }

    public bool AccredditForAllUsers { get; set; }

    public bool ShowCustomersOfOtherUsers { get; set; }

    public bool ShowOfferPricesOfOtherUser { get; set; }

    public bool ShowDashboardForAllUsers { get; set; }

    public bool AllowPrintBarcode { get; set; }

    public bool ShowAllBranchesInCustomerInfo { get; set; }

    public bool ShowAllBranchesInSuppliersInfo { get; set; }

    public int UserAccountId { get; set; }

    public bool? PurchaseShowBalanceOfPerson { get; set; }

    public bool? SalesShowBalanceOfPerson { get; set; }

    public virtual ICollection<OtherSettingsBank> OtherSettingsBanks { get; } = new List<OtherSettingsBank>();

    public virtual ICollection<OtherSettingsSafe> OtherSettingsSaves { get; } = new List<OtherSettingsSafe>();

    public virtual ICollection<OtherSettingsStore> OtherSettingsStores { get; } = new List<OtherSettingsStore>();

    public virtual UserAccount UserAccount { get; set; } = null!;
}
