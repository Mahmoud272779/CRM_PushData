using System;
using System.Collections.Generic;

namespace App.Infrastructure.UserManagementDB;

public partial class Bundle
{
    public int BundleId { get; set; }

    public string? ArabicName { get; set; }

    public string? LatinName { get; set; }

    public bool IsInfinityNumbersOfEmployees { get; set; }

    public int AllowedEmployeesNo { get; set; }

    public int TrialDays { get; set; }

    public decimal BundlePrice { get; set; }

    public bool IsInfinityNumbersOfApps { get; set; }

    public int AllowedNumberOfApps { get; set; }

    public bool IsInfinityNumbersOfUsers { get; set; }

    public int AllowedNumberOfUsers { get; set; }

    public bool IsInfinityNumbersOfStores { get; set; }

    public int AllowedNumberOfStores { get; set; }

    public bool IsInfinityNumbersOfBranchs { get; set; }

    public int AllowedNumberOfBranchs { get; set; }

    public bool IsInfinityNumbersOfInvoices { get; set; }

    public int AllowedNumberOfInvoices { get; set; }

    public bool IsInfinityNumbersOfPos { get; set; }

    public int AllowedNumberOfPos { get; set; }

    public bool IsInfinityNumbersOfSuppliers { get; set; }

    public int AllowedNumberOfSuppliers { get; set; }

    public bool IsInfinityNumbersOfCustomers { get; set; }

    public int AllowedNumberOfCustomers { get; set; }

    public bool IsPosallowed { get; set; }

    public int? Poscount { get; set; }

    public decimal PriceOfMonth { get; set; }

    public decimal PriceOfThreeMonths { get; set; }

    public decimal PriceOfSixMonths { get; set; }

    public decimal PriceOfOneYear { get; set; }

    public int SubscriptionDays { get; set; }

    public bool IsDefault { get; set; }

    public virtual ICollection<Company> Companies { get; } = new List<Company>();

    public virtual ICollection<UserApplicationCash> UserApplicationCashes { get; } = new List<UserApplicationCash>();
}
