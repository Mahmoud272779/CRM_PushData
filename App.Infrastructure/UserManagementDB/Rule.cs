using System;
using System.Collections.Generic;

namespace App.Infrastructure.UserManagementDB;

public partial class Rule
{
    public int Id { get; set; }

    public string ArabicName { get; set; } = null!;

    public string? LatinName { get; set; }

    public bool? IsActive { get; set; }

    public bool CanDelete { get; set; }

    public virtual ICollection<Account> Accounts { get; } = new List<Account>();

    public virtual ICollection<RulesDetail> RulesDetails { get; } = new List<RulesDetail>();
}
