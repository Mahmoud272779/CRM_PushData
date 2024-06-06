using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class ChatGroup
{
    public int Id { get; set; }

    public int GroupCreatorId { get; set; }

    public bool AllowReply { get; set; }

    public string? GroupName { get; set; }

    public string? GroupImage { get; set; }

    public DateTime CreationDate { get; set; }

    public bool IsEnded { get; set; }

    public bool CanExit { get; set; }

    public virtual ICollection<ChatGroupMember> ChatGroupMembers { get; } = new List<ChatGroupMember>();

    public virtual ICollection<ChatMessage> ChatMessages { get; } = new List<ChatMessage>();

    public virtual InvEmployee GroupCreator { get; set; } = null!;
}
