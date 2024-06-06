using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class ChatGroupMember
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int MemberId { get; set; }

    public bool IsAdmin { get; set; }

    public virtual ChatGroup Group { get; set; } = null!;

    public virtual InvEmployee Member { get; set; } = null!;
}
