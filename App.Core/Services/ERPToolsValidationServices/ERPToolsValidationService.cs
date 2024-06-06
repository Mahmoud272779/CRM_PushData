using App.Core.Helper;
using App.Domain.Models.Request.RestfulAPI;
using App.Domain.Models.Response;
using App.Domain.Models.Shared;
using App.Infrastructure.ERPContext;
using App.Infrastructure.UserManagementDB;
using Azure.Core;
using Dapper;
using MediatR;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Services.ERPToolsValidationServices
{
    public class ERPToolsValidationService : IERPToolsValidationService
    {
        private readonly IConfiguration _configuration;
        private readonly IRestfulAPIService _restfulAPIService;

        public ERPToolsValidationService(IConfiguration configuration, IRestfulAPIService restfulAPIService)
        {
            _configuration = configuration;
            _restfulAPIService = restfulAPIService;
        }

        public async Task<string> ERPLogin(string companyName, string username, string password)
        {
            string token = string.Empty;
            companyTokensDTO company = new companyTokensDTO();
            if (Profile.CompaniesToken != null)
                company = Profile.CompaniesToken.Find(c => c.companyLogin == companyName);
            ResponseResult login_responseObj = new ResponseResult();
            if (company == null)
            {
                var loginBodyDto = new erpLoginDTO
                {
                    companyName = companyName+"#"+ Helpers.generateSecretCode(),
                    username = username,
                    password = password
                };

                var loginRes = await _restfulAPIService.Call(new RestfulAPICallingDTO
                {
                    BaseUrl = _configuration["ERPUrls:BackURL"],
                    APIPath = "api/login",
                    Body = JsonConvert.SerializeObject(loginBodyDto),
                    Method = HttpMethod.Post,
                });
                login_responseObj = JsonConvert.DeserializeObject<ResponseResult>(loginRes);
                if (login_responseObj.Result != Domain.Enums.Enums.Result.Success)
                    return null;
                Profile.CompaniesToken.Add(new companyTokensDTO
                {
                    companyLogin = companyName,
                    token = JsonConvert.DeserializeObject<ERPLoginResponse.loginResponse>(login_responseObj.Data.ToString()).authToken.token
                });
                token = JsonConvert.DeserializeObject<ERPLoginResponse.loginResponse>(login_responseObj.Data.ToString()).authToken.token;
            }
            else
            {
                token = company.token;
            }
            return token;
        }

        public async Task<bool> ERPToolsValidation(ERPToolsValidationProps request)
        {
            SqlConnection con = new SqlConnection(_configuration["ConnectionStrings:UserManagerQLConnection"]);
            con.Open();
            try
            {
                var findCompanyQuery = $"SELECT * FROM [ERP_UsersManager].[dbo].[UserApplication] where companyLogin = '{request.companyLogin}'";
                var company = con.Query<UserApplication>(findCompanyQuery).FirstOrDefault();
                if (company == null) return false;
                if(company.Email != request.companyEmail) return false;
                if(company.DatabaseName != request.companyDatabaseName) return false;
                if(company.Phone != request.companyPhone) return false;
                con.Close();
                con.ConnectionString = ConHelper.BuildConnectionString(_configuration,company.DatabaseName);
                con.Open();
                var getClientSAUserQuery = "SELECT * FROM [Apex_TestAccountantTree].[dbo].[userAccount] where Id = 1";
                var SAUser = con.Query<UserAccount>(getClientSAUserQuery).FirstOrDefault();
                if(SAUser == null) return false;
                if(SAUser.Username != SAUser.Username) return false;
                if(SAUser.Password != SAUser.Password) return false;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return false;

        }
    }
}
