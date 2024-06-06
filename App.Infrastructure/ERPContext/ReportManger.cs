using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class ReportManger
{
    public int Id { get; set; }

    public int ScreenId { get; set; }

    public int ArabicFilenameId { get; set; }

    public bool IsArabic { get; set; }

    public int Copies { get; set; }

    public virtual ReportFile ArabicFilename { get; set; } = null!;

    public virtual ScreenName Screen { get; set; } = null!;
}
