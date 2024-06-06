using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class SubCodeLevel
{
    public int Id { get; set; }

    public int Value { get; set; }

    public int GlgeneralSettingId { get; set; }

    public virtual GlgeneralSetting GlgeneralSetting { get; set; } = null!;
}
