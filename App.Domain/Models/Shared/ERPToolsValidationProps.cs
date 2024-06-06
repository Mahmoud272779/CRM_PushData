using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Models.Shared
{
    public class ERPToolsValidationProps
    {
        public string companyLogin { get; set; }
        public string companyEmail { get; set; }
        public string companyDatabaseName { get; set; }
        public string companyPhone { get; set; }
        public string sa_username { get; set; }
        public string sa_password { get; set; }

    }
}
