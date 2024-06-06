using App.Infrastructure.DefultData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Helper
{
    public static class Helpers
    {
        public static string generateSecretCode()
        {
            var key = StringEncryption.EncryptString(defultData.userManagmentApplicationSecurityKey + DateTime.Now.ToString("yyyyMM-dd"));
            return key;
        }
    }
}
