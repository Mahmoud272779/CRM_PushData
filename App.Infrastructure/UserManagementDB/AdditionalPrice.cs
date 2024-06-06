using System;
using System.Collections.Generic;

namespace App.Infrastructure.UserManagementDB;

public partial class AdditionalPrice
{
    public int Id { get; set; }

    public string ArabicName { get; set; } = null!;

    public string? LatinName { get; set; }

    public double Price { get; set; }

    public bool SpecialApps { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<AdditionalPriceSubscription> AdditionalPriceSubscriptions { get; } = new List<AdditionalPriceSubscription>();

    public virtual ICollection<App> Apps { get; } = new List<App>();
}
