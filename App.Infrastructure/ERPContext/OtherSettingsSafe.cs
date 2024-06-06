using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class OtherSettingsSafe
{
    public int Id { get; set; }

    public int GLsafeId { get; set; }

    public int OtherSettingsId { get; set; }

    public virtual Glsafe GLsafe { get; set; } = null!;

    public virtual OtherSetting OtherSettings { get; set; } = null!;
}
