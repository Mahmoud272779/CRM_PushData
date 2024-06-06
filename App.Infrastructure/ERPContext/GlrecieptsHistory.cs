using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GlrecieptsHistory
{
    public int Id { get; set; }

    public int ReceiptsId { get; set; }

    public int SafeIdorBank { get; set; }

    public int Code { get; set; }

    public DateTime RecieptDate { get; set; }

    public double Amount { get; set; }

    public int AuthorityType { get; set; }

    public int PaymentMethodId { get; set; }

    public string? ChequeNumber { get; set; }

    public int RecieptTypeId { get; set; }

    public string? RecieptType { get; set; }

    public int Signal { get; set; }

    public double Serialize { get; set; }

    public int BranchId { get; set; }

    public int UserId { get; set; }

    public bool IsAccredit { get; set; }

    public int BenefitId { get; set; }

    public bool IsBlock { get; set; }

    public string? ReceiptsAction { get; set; }

    public DateTime? LastDate { get; set; }

    public string? BrowserName { get; set; }

    public int EmployeesId { get; set; }

    public virtual InvEmployee Employees { get; set; } = null!;
}
