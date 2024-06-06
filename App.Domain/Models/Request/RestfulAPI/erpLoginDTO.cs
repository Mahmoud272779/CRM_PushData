using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Models.Request.RestfulAPI
{
    public class erpLoginDTO
    {
        public string companyName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
