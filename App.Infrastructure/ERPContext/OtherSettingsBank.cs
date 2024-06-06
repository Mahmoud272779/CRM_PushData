using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class OtherSettingsBank
{
    public int Id { get; set; }

    public int GLbankId { get; set; }

    public int OtherSettingsId { get; set; }

    public virtual Glbank GLbank { get; set; } = null!;

    public virtual OtherSetting OtherSettings { get; set; } = null!;
}
