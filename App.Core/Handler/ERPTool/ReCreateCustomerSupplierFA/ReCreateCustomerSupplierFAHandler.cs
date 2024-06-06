using App.Core.Helper;
using App.Core.Services.ERPToolsValidationServices;
using App.Domain.Models.Request.RestfulAPI;
using App.Domain.Models.Response;
using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using MediatR;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace App.Core.Handler.ERPTool.ReCreateCustomerFA
{
    public class ReCreateCustomerSupplierFAHandler : IRequestHandler<ReCreateCustomerSupplierFARequest, ResponseResult>
    {
        private readonly IRestfulAPIService _restfulAPIService;
        private readonly IConfiguration _configuration;
        private readonly IERPToolsValidationService _ERPToolsValidationService;
        public ReCreateCustomerSupplierFAHandler(IRestfulAPIService restfulAPIService, IConfiguration configuration, IERPToolsValidationService eRPToolsValidationService)
        {
            _restfulAPIService = restfulAPIService;
            _configuration = configuration;
            _ERPToolsValidationService = eRPToolsValidationService;
        }
        public async Task<ResponseResult> Handle(ReCreateCustomerSupplierFARequest request, CancellationToken cancellationToken)
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

            string token = await _ERPToolsValidationService.ERPLogin(request.companyLogin,request.sa_username,request.sa_password);
            if(token == null) return new ResponseResult { Result = Domain.Enums.Enums.Result.UnAuthorized, Note = "Company information is wrong" };
            
            var _queryParams = new (string key, string value)[]
            {
                ("newParentId", request.newParentId.ToString()),
                ("OldAccountId", request.OldAccountId.ToString())
            };
            var _headers = new (string key, string value)[]
            {
                ("key", defultData.userManagmentApplicationSecurityKey)
            };
            var totalPersons = 1;
            var APIPath = string.Empty;
            if (request.types == Domain.Enums.Enums.PersonTypes.customer)
                APIPath = "api/ReCreateCustomerFA";
            else if(request.types == Domain.Enums.Enums.PersonTypes.supplier)
                APIPath = "api/ReCreateSupplierFA";


            while (totalPersons != 0)
            {
                var res = await _restfulAPIService.Call(new RestfulAPICallingDTO
                {
                    BaseUrl = _configuration["ERPUrls:BackURL"],
                    APIPath = APIPath,
                    Body = "",
                    Method = HttpMethod.Post,
                    queryParams = _queryParams,
                    Headers = _headers,
                    isAuth = true,
                    token = token
                });
                var ReCreateCustomerFA_ResponseObj = JsonConvert.DeserializeObject<ResponseResult>(res);
                totalPersons = ReCreateCustomerFA_ResponseObj.TotalCount;
                Thread.Sleep(1000);
            }


            return new ResponseResult()
            {
                Result = Domain.Enums.Enums.Result.Success
            };
        }
    }
}
