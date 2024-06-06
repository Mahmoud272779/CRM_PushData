using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GlrecieptFile
{
    public int Id { get; set; }

    public int RecieptId { get; set; }

    public string? FileLink { get; set; }

    public string? FileName { get; set; }

    public string? FileExtensions { get; set; }

    public virtual GlReciept Reciept { get; set; } = null!;
}
