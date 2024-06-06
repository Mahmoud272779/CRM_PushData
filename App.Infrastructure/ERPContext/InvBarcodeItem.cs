using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvBarcodeItem
{
    public int Id { get; set; }

    public int BarcodeId { get; set; }

    public int BarcodeItemType { get; set; }

    public double Width { get; set; }

    public double Height { get; set; }

    public double X { get; set; }

    public double Y { get; set; }

    public double PositionX { get; set; }

    public double PositionY { get; set; }

    public string? FontType { get; set; }

    public double FontSize { get; set; }

    public bool Bold { get; set; }

    public bool Italic { get; set; }

    public bool UnderLine { get; set; }

    public string? AlignX { get; set; }

    public string? AlignY { get; set; }

    public string? Dock { get; set; }

    public byte[]? Image { get; set; }

    public string? ImagePath { get; set; }

    public string? ImageName { get; set; }

    public bool IsLogo { get; set; }

    public int Direction { get; set; }

    public int TextType { get; set; }

    public string? TextContent { get; set; }

    public int VariableContent { get; set; }

    public string? BeginSplitter { get; set; }

    public string? EndSplitter { get; set; }

    public int BarcodeType { get; set; }

    public virtual InvBarcodeTemplate Barcode { get; set; } = null!;
}
