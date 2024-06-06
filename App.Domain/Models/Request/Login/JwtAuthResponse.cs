using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Models.Request.Login
{
    public class JwtAuthResponse
    {
        public string token { get; set; }
        public string userId { get; set; }
        public string userName { get; set; }
        public string arabicName { get; set; }
        public string latinName { get; set; }
        public string permissionNameAr { get; set; }
        public string permissionNameEn { get; set; }
        public string imageUrl { get; set; }
    }
}
