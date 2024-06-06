using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Helper
{
    public static class Profile
    {
        public static List<companyTokensDTO> CompaniesToken { get; set; } = new List<companyTokensDTO>();
    }
    public class companyTokensDTO
    {
        public string companyLogin { get; set; }
        public string token { get; set; }
    }
}
