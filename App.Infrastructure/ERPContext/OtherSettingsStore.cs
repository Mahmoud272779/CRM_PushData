using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class OtherSettingsStore
{
    public int Id { get; set; }

    public int InvStpStoresId { get; set; }

    public int OtherSettingsId { get; set; }

    public virtual InvStpStore InvStpStores { get; set; } = null!;

    public virtual OtherSetting OtherSettings { get; set; } = null!;
}
