using App.Core.Helper;
using App.Core.Services.ERPToolsValidationServices;
using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using MediatR;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Handler.ERPTool.ReCreateJournalEntry
{
    public class ReCreateJournalEntryHandler : IRequestHandler<ReCreateJournalEntryRequest, ResponseResult>
    {
        private readonly IERPToolsValidationService _ERPToolsValidationService;
        private readonly IRestfulAPIService _restfulAPIService;
        private readonly IConfiguration _configuration;

        public ReCreateJournalEntryHandler(IERPToolsValidationService eRPToolsValidationService, IRestfulAPIService restfulAPIService, IConfiguration configuration)
        {
            _ERPToolsValidationService = eRPToolsValidationService;
            _restfulAPIService = restfulAPIService;
            _configuration = configuration;
        }
        public async Task<ResponseResult> Handle(ReCreateJournalEntryRequest request, CancellationToken cancellationToken)
        {
            if (!_ERPToolsValidationService.ERPToolsValidation(new ERPToolsValidationProps
            {
                companyDatabaseName = request.companyDatabaseName,
                companyEmail = request.companyEmail,
                companyLogin = request.companyLogin,
                companyPhone = request.companyPhone,
                sa_password = request.sa_password,
                sa_username = request.sa_username
            }).Result) return new ResponseResult { Result = Domain.Enums.Enums.Result.UnAuthorized, Note = "Company information is wrong" };

            string token = await _ERPToolsValidationService.ERPLogin(request.companyLogin, request.sa_username, request.sa_password);
            if (token == null) return new ResponseResult { Result = Domain.Enums.Enums.Result.UnAuthorized, Note = "Company information is wrong" };

            var _queryParams = new (string key, string value)[]
            {
                ("type", request.type.ToString())
            };
            var _headers = new (string key, string value)[]
            {
                ("key", defultData.userManagmentApplicationSecurityKey)
            };

            var res = await _restfulAPIService.Call(new RestfulAPICallingDTO
            {
                BaseUrl = _configuration["ERPUrls:BackURL"],
                APIPath = "api/ReCreateJournalEntry",
                Body = "",
                Method = HttpMethod.Post,
                queryParams = _queryParams,
                Headers = _headers,
                isAuth = true,
                token = token
            });
            var ReCreateJournalEntry_ResponseObj = JsonConvert.DeserializeObject<ResponseResult>(res);

         

            return new ResponseResult
            {
                Result = ReCreateJournalEntry_ResponseObj.Result == Domain.Enums.Enums.Result.Success ? Domain.Enums.Enums.Result.Success : Domain.Enums.Enums.Result.Failed
            };
        }
    }
}
