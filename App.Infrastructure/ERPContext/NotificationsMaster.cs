using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class NotificationsMaster
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Desc { get; set; }

    public string? TitleEn { get; set; }

    public string? DescEn { get; set; }

    public bool IsSystem { get; set; }

    public int? PageId { get; set; }

    public int? SpecialUserId { get; set; }

    public DateTime CDate { get; set; }

    public int? InsertedById { get; set; }

    public string? RouteUrl { get; set; }

    public virtual InvEmployee? InsertedBy { get; set; }

    public virtual ICollection<NotificationSeen> NotificationSeens { get; } = new List<NotificationSeen>();

    public virtual InvEmployee? SpecialUser { get; set; }
}
