using System;
using System.Collections.Generic;

namespace App.Infrastructure.UserManagementDB;

public partial class App
{
    public int Id { get; set; }

    public string ArabicName { get; set; } = null!;

    public string? LatinName { get; set; }

    public double Price { get; set; }

    public string? Note { get; set; }

    public virtual ICollection<UserApplicationApp> UserApplicationApps { get; } = new List<UserApplicationApp>();

    public virtual ICollection<AdditionalPrice> AdditionalPrices { get; } = new List<AdditionalPrice>();

    public virtual ICollection<App> AppChildren { get; } = new List<App>();

    public virtual ICollection<App> AppParents { get; } = new List<App>();
}
