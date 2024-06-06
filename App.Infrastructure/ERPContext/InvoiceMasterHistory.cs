using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvoiceMasterHistory
{
    public int Id { get; set; }

    public int InvoiceId { get; set; }

    public string? InvoiceType { get; set; }

    public int Code { get; set; }

    public double Serialize { get; set; }

    public string? ParentInvoiceCode { get; set; }

    public bool IsDeleted { get; set; }

    public string? BookIndex { get; set; }

    public DateTime InvoiceDate { get; set; }

    public int StoreId { get; set; }

    public double TotalPrice { get; set; }

    public string? Notes { get; set; }

    public int InvoiceTypeId { get; set; }

    public int SubType { get; set; }

    public string? LastAction { get; set; }

    public DateTime? LastDate { get; set; }

    public string? BrowserName { get; set; }

    public int EmployeesId { get; set; }

    public int BranchId { get; set; }

    public string? LastTransactionAction { get; set; }

    public string? AddTransactionUser { get; set; }

    public string? AddTransactionDate { get; set; }

    public string? LastTransactionUser { get; set; }

    public string? LastTransactionDate { get; set; }

    public string? DeleteTransactionUser { get; set; }

    public string? DeleteTransactionDate { get; set; }

    public string? LastTransactionUserAr { get; set; }

    public virtual InvEmployee Employees { get; set; } = null!;
}
