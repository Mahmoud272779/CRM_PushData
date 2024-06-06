﻿using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GlcostCenterHistory
{
    public int Id { get; set; }

    public int CostCenterId { get; set; }

    public double InitialBalance { get; set; }

    public int CcNature { get; set; }

    public string? Notes { get; set; }

    public int? ParentId { get; set; }

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

    public string? LatinName { get; set; }

    public string? ArabicName { get; set; }

    public virtual InvEmployee Employees { get; set; } = null!;
}
