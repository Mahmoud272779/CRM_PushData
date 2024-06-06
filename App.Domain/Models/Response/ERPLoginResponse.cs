using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Models.Response
{
    public class ERPLoginResponse
    {
        public class loginResponse
        {
            public bool isPeriodEnded { get; set; }
            public DateTime startPeriod { get; set; }
            public DateTime endPeriod { get; set; }
            public object apps { get; set; }
            public JwtAuthResponse authToken { get; set; }
            public bool isHaveUpdate { get; set; }
            public object Premissions { get; set; }
            public companyInfo companyInfo { get; set; }
            public int updateNumber { get; set; }
            public int ServerID { get; set; }
        }
        public class companyInfo
        {
            public string companyNameAr { get; set; }
            public string companyNameEn { get; set; }
            public int subId { get; set; }
        }
        public class JwtAuthResponse
        {
            public string token { get; set; }
            public userInfo UserInfo { get; set; }
            public object AllowedModule { get; set; }
            public object AllowedForms { get; set; }
            public DateTime expires_in { get; set; }
        }
        public class userInfo
        {
            public string userId { get; set; }
            public string userName { get; set; }
            public string arabicName { get; set; }
            public string latinName { get; set; }
            public string permissionNameAr { get; set; }
            public string permissionNameEn { get; set; }
            public string imageUrl { get; set; }
        }
    }
}
