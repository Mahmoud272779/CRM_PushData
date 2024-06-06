using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GlintegrationSetting
{
    public int Id { get; set; }

    public int LinkingMethodId { get; set; }

    public int ScreenId { get; set; }

    public int GlfinancialAccountId { get; set; }

    public int GlbranchId { get; set; }

    public virtual Glbranch Glbranch { get; set; } = null!;

    public virtual GlfinancialAccount GlfinancialAccount { get; set; } = null!;
}
