using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class BarcodePrintFile
{
    public int Id { get; set; }

    public string? ArabicName { get; set; }

    public string? LatineName { get; set; }

    public byte[]? File { get; set; }

    public bool IsDefault { get; set; }
}
