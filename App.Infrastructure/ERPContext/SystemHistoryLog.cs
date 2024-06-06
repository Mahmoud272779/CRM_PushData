using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class SystemHistoryLog
{
    public int Id { get; set; }

    public int EmployeesId { get; set; }

    public int? BranchId { get; set; }

    public int TransactionId { get; set; }

    public string? ActionArabicName { get; set; }

    public string? ActionLatinName { get; set; }

    public DateTime Date { get; set; }

    public virtual Glbranch? Branch { get; set; }

    public virtual InvEmployee Employees { get; set; } = null!;
}
