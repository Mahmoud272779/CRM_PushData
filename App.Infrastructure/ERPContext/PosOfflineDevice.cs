using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class PosOfflineDevice
{
    public int Id { get; set; }

    public string? DeviceSerial { get; set; }

    public int ServiceId { get; set; }

    public bool DeleteWaiting { get; set; }
}
