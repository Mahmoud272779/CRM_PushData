using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class ChatMessage
{
    public int Id { get; set; }

    public int FromId { get; set; }

    public int? ToId { get; set; }

    public int? GroupId { get; set; }

    public string? Message { get; set; }

    public DateTime Date { get; set; }

    public bool Seen { get; set; }

    public DateTime SeenDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime DeleteDate { get; set; }

    public bool IsPrivate { get; set; }

    public virtual InvEmployee From { get; set; } = null!;

    public virtual ChatGroup? Group { get; set; }

    public virtual InvEmployee? To { get; set; }
}
