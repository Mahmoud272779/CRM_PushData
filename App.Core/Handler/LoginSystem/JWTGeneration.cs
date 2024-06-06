using App.Core.Helper;
using App.Domain.Models.Request.Login;
using App.Infrastructure.DefultData;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace App.Core.Handler.LoginSystem
{
    public static class JWTGeneration
    {
        public static async Task<JwtAuthResponse> getAuthToken(string employeeId,int userId, string RoleID)
        {
            var encreptedRuleID = StringEncryption.EncryptString(RoleID);
            var encreptedUserID = StringEncryption.EncryptString(userId.ToString());
            var encryptedEmployeeId = StringEncryption.EncryptString(employeeId);

            var claims = new[]
            {
                new Claim("RoleDetails",encreptedRuleID),
                new Claim("userID",encreptedUserID),
                new Claim("employeeId",encryptedEmployeeId)
            };
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            var securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(defultData.JWT_SECURITY_KEY));
            var expiryInHours = DateTime.Now.AddHours(defultData.JWT_TOKEN_VALIDAIT_Time);
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var token = tokenHandler.WriteToken(new JwtSecurityToken
                (
                    issuer: defultData.site,
                    audience: defultData.site,
                    expires: expiryInHours,
                    signingCredentials: credentials,
                    claims: claims
                ));

            return new JwtAuthResponse()
            {
                token = token.ToString(),
                userId = encreptedUserID
            };
        }
    }
}
