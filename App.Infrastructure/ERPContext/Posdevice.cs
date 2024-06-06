using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class Posdevice
{
    public int Id { get; set; }

    public string? DeviceId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }
}
