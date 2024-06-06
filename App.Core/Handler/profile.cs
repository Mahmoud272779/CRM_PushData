using App.Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Handler
{
    public static class profile
    {
        public static List<AttendanceMachineCompanies> companies  = new List<AttendanceMachineCompanies>();
        public static List<AttendanceMachineCompanies> companiesNotExist  = new List<AttendanceMachineCompanies>();
    }
}
