using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GlgeneralSetting
{
    public int Id { get; set; }

    public bool IsFundsClosed { get; set; }

    public bool AutomaticCoding { get; set; }

    public int? MainCode { get; set; }

    public int? SubCode { get; set; }

    public int EvaluationMethodOfEndOfPeriodStockType { get; set; }

    public int DefultAccCustomer { get; set; }

    public int DefultAccEmployee { get; set; }

    public int DefultAccSalesMan { get; set; }

    public int DefultAccOtherAuthorities { get; set; }

    public int DefultAccBank { get; set; }

    public int DefultAccSafe { get; set; }

    public int DefultAccSupplier { get; set; }

    public int FinancialAccountIdCustomer { get; set; }

    public int FinancialAccountIdEmployee { get; set; }

    public int FinancialAccountIdSalesMan { get; set; }

    public int FinancialAccountIdOtherAuthorities { get; set; }

    public int FinancialAccountIdBank { get; set; }

    public int FinancialAccountIdSafe { get; set; }

    public int FinancialAccountIdSupplier { get; set; }

    public int BranchId { get; set; }

    public string? LastTransactionAction { get; set; }

    public string? AddTransactionUser { get; set; }

    public string? AddTransactionDate { get; set; }

    public string? LastTransactionUser { get; set; }

    public string? LastTransactionDate { get; set; }

    public string? DeleteTransactionUser { get; set; }

    public string? DeleteTransactionDate { get; set; }

    public string? LastTransactionUserAr { get; set; }

    public virtual ICollection<SubCodeLevel> SubCodeLevels { get; } = new List<SubCodeLevel>();
}
