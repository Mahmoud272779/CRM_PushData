﻿using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GlbanksHistory
{
    public int Id { get; set; }

    public string? LatinName { get; set; }

    public string? ArabicName { get; set; }

    public int BankId { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? AccountNumber { get; set; }

    public int? FinancialAccountId { get; set; }

    public int Status { get; set; }

    public string? AddressAr { get; set; }

    public string? AddressEn { get; set; }

    public string? Notes { get; set; }

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
