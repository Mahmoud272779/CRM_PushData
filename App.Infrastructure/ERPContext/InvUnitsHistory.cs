using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvUnitsHistory
{
    public int Id { get; set; }

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

    public int EntityId { get; set; }

    public string? LatinName { get; set; }

    public string? ArabicName { get; set; }

    public string? BrowserName { get; set; }

    public virtual InvEmployee Employees { get; set; } = null!;
}
