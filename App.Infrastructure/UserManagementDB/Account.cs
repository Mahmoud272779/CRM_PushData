using System;
using System.Collections.Generic;

namespace App.Infrastructure.UserManagementDB;

public partial class Account
{
    public int Id { get; set; }

    public string? ArabicName { get; set; }

    public string? Email { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public bool IsActive { get; set; }

    public bool? AllowTrialperiod { get; set; }

    public bool? BindTrialAccounts { get; set; }

    public bool? AccreditAppsAccounts { get; set; }

    public bool? AccreditAppsTechnicals { get; set; }

    public bool? ConfirmApps { get; set; }

    public int RuleId { get; set; }

    public virtual Rule Rule { get; set; } = null!;

    public virtual ICollection<SigninLog> SigninLogs { get; } = new List<SigninLog>();

    public virtual ICollection<UserApplicationCash> UserApplicationCashAccAccounts { get; } = new List<UserApplicationCash>();

    public virtual ICollection<UserApplicationCash> UserApplicationCashAccManagers { get; } = new List<UserApplicationCash>();

    public virtual ICollection<UserApplicationCash> UserApplicationCashAccTeches { get; } = new List<UserApplicationCash>();
}
