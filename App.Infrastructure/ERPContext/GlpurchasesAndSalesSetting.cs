using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GlpurchasesAndSalesSetting
{
    public int Id { get; set; }

    public string? LatinName { get; set; }

    public string? ArabicName { get; set; }

    public int ReceiptElemntId { get; set; }

    public int RecieptsType { get; set; }

    public int MainType { get; set; }

    public int? FinancialAccountId { get; set; }

    public int BranchId { get; set; }

    public virtual Glbranch Branch { get; set; } = null!;

    public virtual GlfinancialAccount? FinancialAccount { get; set; }
}
