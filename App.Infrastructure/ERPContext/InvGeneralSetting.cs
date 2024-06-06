using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvGeneralSetting
{
    public int Id { get; set; }

    public bool PurchasesModifyPrices { get; set; }

    public bool PurchasesPayTotalNet { get; set; }

    public bool PurchasesUseLastPrice { get; set; }

    public bool PurchasesPriceIncludeVat { get; set; }

    public bool PurchasesPrintWithSave { get; set; }

    public bool PurchasesReturnWithoutQuantity { get; set; }

    public bool PurchasesActiveDiscount { get; set; }

    public bool PosModifyPrices { get; set; }

    public bool PosExceedPrices { get; set; }

    public bool PosExceedDiscountRatio { get; set; }

    public bool PosUseLastPrice { get; set; }

    public bool PosActivePricesList { get; set; }

    public bool PosExtractWithoutQuantity { get; set; }

    public bool PosPriceIncludeVat { get; set; }

    public bool PosActiveDiscount { get; set; }

    public bool PosDeferredSale { get; set; }

    public bool PosIndividualCoding { get; set; }

    public bool PosPreventEditingRecieptFlag { get; set; }

    public int PosPreventEditingRecieptValue { get; set; }

    public bool PosActiveCashierCustody { get; set; }

    public bool PosPrintPreview { get; set; }

    public bool PosPrintWithEnding { get; set; }

    public bool PosEditingOnDate { get; set; }

    public bool SalesModifyPrices { get; set; }

    public bool SalesExceedPrices { get; set; }

    public bool SalesExceedDiscountRatio { get; set; }

    public bool SalesPayTotalNet { get; set; }

    public bool SalesUseLastPrice { get; set; }

    public bool SalesExtractWithoutQuantity { get; set; }

    public bool SalesPriceIncludeVat { get; set; }

    public bool SalesPrintWithSave { get; set; }

    public bool SalesActiveDiscount { get; set; }

    public bool SalesLinkRepresentCustomer { get; set; }

    public bool SalesActivePricesList { get; set; }

    public bool OtherMergeItems { get; set; }

    public string? OtherMergeItemMethod { get; set; }

    public bool OtherItemsAutoCoding { get; set; }

    public bool OtherZeroPricesInItems { get; set; }

    public bool OtherPrintSerials { get; set; }

    public bool OtherAutoExtractExpireDate { get; set; }

    public bool OtherViewStorePlace { get; set; }

    public bool OtherConfirmeSupplierPhone { get; set; }

    public bool OtherConfirmeCustomerPhone { get; set; }

    public bool OtherDemandLimitNotification { get; set; }

    public bool OtherExpireNotificationFlag { get; set; }

    public int OtherExpireNotificationValue { get; set; }

    public int OtherDecimals { get; set; }

    public bool OtherUseRoundNumber { get; set; }

    public bool FundsItems { get; set; }

    public bool FundsSupplires { get; set; }

    public DateTime? FundsSuppliresDate { get; set; }

    public bool FundsCustomers { get; set; }

    public DateTime? FundsCustomersDate { get; set; }

    public bool FundsSafes { get; set; }

    public bool FundsBanks { get; set; }

    public string? BarcodeType { get; set; }

    public bool BarcodeItemCodestart { get; set; }

    public bool VatActive { get; set; }

    public double VatDefaultValue { get; set; }

    public DateTime AccrediteStartPeriod { get; set; }

    public DateTime AccrediteEndPeriod { get; set; }

    public bool CustomerDisplayActive { get; set; }

    public string? CustomerDisplayPortNumber { get; set; }

    public int CustomerDisplayCode { get; set; }

    public int CustomerDisplayLinesNumber { get; set; }

    public int CustomerDisplayCharNumber { get; set; }

    public string? CustomerDisplayDefaultWord { get; set; }

    public int CustomerDisplayScreenType { get; set; }

    public string? Email { get; set; }

    public string? EmailPassword { get; set; }

    public string? EmailDisplayName { get; set; }

    public string? EmailHost { get; set; }

    public int EmailPort { get; set; }

    public int SecureSocketOptions { get; set; }

    public int AutoLogoutInMints { get; set; }

    public int UpdateFilesNumber { get; set; }

    public int BranchId { get; set; }

    public string? LastTransactionAction { get; set; }

    public string? AddTransactionUser { get; set; }

    public string? AddTransactionDate { get; set; }

    public string? LastTransactionUser { get; set; }

    public string? LastTransactionDate { get; set; }

    public string? DeleteTransactionUser { get; set; }

    public string? DeleteTransactionDate { get; set; }

    public string? LastTransactionUserAr { get; set; }

    public bool? PurchaseUpdateItemsPricesAfterInvoice { get; set; }
}
