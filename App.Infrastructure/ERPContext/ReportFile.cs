using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class ReportFile
{
    public int Id { get; set; }

    public string? ReportFileName { get; set; }

    public string? ReportFileNameAr { get; set; }

    public bool IsArabic { get; set; }

    public int IsReport { get; set; }

    public byte[]? Files { get; set; }

    public bool IsDefault { get; set; }

    public DateTime UTime { get; set; }

    public virtual ICollection<ReportManger> ReportMangers { get; } = new List<ReportManger>();
}
