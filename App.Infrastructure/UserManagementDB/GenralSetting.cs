using System;
using System.Collections.Generic;

namespace App.Infrastructure.UserManagementDB;

public partial class GenralSetting
{
    public int Id { get; set; }

    public int NotificateClientForActiveSubscraptionInDays { get; set; }

    public bool? SendSmstoClientForActiveSubscraption { get; set; }

    public bool? SendEmailToClientForActiveSubscraption { get; set; }

    public bool? SendSmsforSalesManAfterActiveSubscrape { get; set; }

    public bool? SendEmailForSalesManAfterActiveSubscrape { get; set; }

    public bool? SendSmstoGenralManagerForActiveSubscraption { get; set; }

    public string? GenralManagerEmail { get; set; }

    public bool? SendEmailToSalesManagerForActiveSubscraption { get; set; }

    public string? SalesManagerEmail { get; set; }

    public bool? SendEmailToAccountantForActiveSubscraption { get; set; }

    public string? AccountantEmail { get; set; }

    public bool? SendEmailToTechncalSupportForActiveSubscraption { get; set; }

    public string? TechncalSupportEmail { get; set; }
}
