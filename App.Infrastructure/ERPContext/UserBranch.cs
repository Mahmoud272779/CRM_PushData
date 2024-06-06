using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class UserBranch
{
    public int Id { get; set; }

    public int UserAccountId { get; set; }

    public int GlbranchId { get; set; }

    public virtual Glbranch Glbranch { get; set; } = null!;

    public virtual UserAccount UserAccount { get; set; } = null!;
}
