using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class DeletedRecord
{
    public int Id { get; set; }

    public int Type { get; set; }

    public DateTime Dtime { get; set; }

    public int RecordId { get; set; }
}
