using System;
using System.Collections.Generic;

namespace App.Infrastructure.UserManagementDB;

public partial class UserApplication
{
    public int Id { get; set; }

    public DateTime CDate { get; set; }

    public string? CompanyNameEn { get; set; }

    public string? Vatno { get; set; }

    public int EmployeesNumber { get; set; }

    public string? Country { get; set; }

    public string? CityName { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? DatabaseName { get; set; }

    public string? CompanyActivity { get; set; }

    public string? CompanyLogin { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public bool? IsDatabaseCreating { get; set; }

    public virtual ICollection<SubReqPeriod> SubReqPeriods { get; } = new List<SubReqPeriod>();

    public virtual ICollection<UserApplicationCash> UserApplicationCashes { get; } = new List<UserApplicationCash>();
}
