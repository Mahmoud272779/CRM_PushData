using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class PostouchSetting
{
    public int Id { get; set; }

    public string? DeviceId { get; set; }

    public int UserId { get; set; }

    public double PosTouchFontSize { get; set; }

    public double PosTouchCategoryImgWidth { get; set; }

    public double PosTouchCategoryImgHeight { get; set; }

    public double PosTouchTableWidth { get; set; }

    public double PosTouchItemsImgWidth { get; set; }

    public double PosTouchItemsImgHeight { get; set; }

    public bool PosTouchDisplayItemPrice { get; set; }
}
