using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using App.Infrastructure.ERPContext;
using App.Infrastructure.UserManagementDB;
using Azure.Core;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Helper
{
    public static class ContextHelper
    {
        public static Dictionary<string, string> DecodingToken(string token)
        {
            var TokenInfo = new Dictionary<string, string>();


            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            var claims = jwtSecurityToken.Claims.ToList();

            foreach (var claim in claims)
            {
                TokenInfo.Add(claim.Type, claim.Value);
            }

            return TokenInfo;
        }

        public static ApexERPContext GetContext(IConfiguration _configuration, int CompanyId)
        {
            ErpUsersManagerContext managerContext = new ErpUsersManagerContext(_configuration);
            var company = managerContext.UserApplications.Where(x => x.Id == CompanyId).FirstOrDefault();
            //check if company exist
            if (company == null)
                return null;
            ApexERPContext apexERPContext = new ApexERPContext(_configuration, company.DatabaseName);
            return apexERPContext;
        }
    }

}
