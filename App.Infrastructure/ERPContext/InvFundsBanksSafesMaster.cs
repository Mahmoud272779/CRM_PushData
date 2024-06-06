using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class InvFundsBanksSafesMaster
{
    public int DocumentId { get; set; }

    public int Code { get; set; }

    public DateTime DocDate { get; set; }

    public int? BankId { get; set; }

    public int? SafeId { get; set; }

    public string? Notes { get; set; }

    public bool IsBank { get; set; }

    public bool IsSafe { get; set; }

    public bool IsBlock { get; set; }

    public int BranchId { get; set; }

    public virtual Glbank? Bank { get; set; }

    public virtual ICollection<InvFundsBanksSafesDetail> InvFundsBanksSafesDetails { get; } = new List<InvFundsBanksSafesDetail>();

    public virtual Glsafe? Safe { get; set; }
}
