using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GlotherAuthoritiesHistory
{
    public int Id { get; set; }

    public int AuthorityId { get; set; }

    public string? LatinName { get; set; }

    public string? ArabicName { get; set; }

    public int? FinancialAccountId { get; set; }

    public int BranchId { get; set; }

    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? LastAction { get; set; }

    public DateTime LastDate { get; set; }

    public string? BrowserName { get; set; }

    public int EmployeesId { get; set; }

    public virtual InvEmployee Employees { get; set; } = null!;
}
