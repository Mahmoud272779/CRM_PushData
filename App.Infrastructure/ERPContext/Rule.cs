using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class Rule
{
    public int Id { get; set; }

    public int MainFormCode { get; set; }

    public int SubFormCode { get; set; }

    public int ApplicationId { get; set; }

    public bool IsVisible { get; set; }

    public string? ArabicName { get; set; }

    public string? LatinName { get; set; }

    public int PermissionListId { get; set; }

    public bool IsShow { get; set; }

    public bool IsAdd { get; set; }

    public bool IsEdit { get; set; }

    public bool IsDelete { get; set; }

    public bool IsPrint { get; set; }

    public DateTime Utime { get; set; }

    public virtual PermissionList PermissionList { get; set; } = null!;
}
