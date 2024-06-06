using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GlrecHistory
{
    public int Id { get; set; }

    public int JournalEntryId { get; set; }

    public int Code { get; set; }

    public DateTime Time { get; set; }

    public int EmployeeId { get; set; }

    public string? Details { get; set; }

    public string? Version { get; set; }

    public string? MacAdress { get; set; }

    public string? Os { get; set; }

    public int HistoryType { get; set; }

    public string? LastAction { get; set; }

    public DateTime LastDate { get; set; }

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
