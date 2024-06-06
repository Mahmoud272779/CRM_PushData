using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvEmployeesBranch
{
    public int EmployeeId { get; set; }

    public int BranchId { get; set; }

    public bool Current { get; set; }

    public virtual Glbranch Branch { get; set; } = null!;

    public virtual InvEmployee Employee { get; set; } = null!;
}
