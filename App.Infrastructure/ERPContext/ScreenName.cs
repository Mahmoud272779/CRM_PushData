using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class ScreenName
{
    public int Id { get; set; }

    public string? ScreenNameAr { get; set; }

    public string? ScreenNameEn { get; set; }

    public virtual ICollection<ReportManger> ReportMangers { get; } = new List<ReportManger>();
}
