using App.Core.Helper;
using App.Domain.Models.Response;
using App.Domain.Models.Shared;
using App.Infrastructure.UserManagementDB;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.ReportsSystem.GetAllCompanies
{
    public class CompaniesHandler : IRequestHandler<CompaniesRequest, ResponseResult>
    {
        private readonly IConfiguration _configuration;

        public CompaniesHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<ResponseResult> Handle(CompaniesRequest request, CancellationToken cancellationToken)
        {
            var userManagerContext = new ErpUsersManagerContext(_configuration);
            var res = userManagerContext.UserApplications
                .Where(x=> x.CompanyLogin == request.SearchCriteria)
                .Select(x => new CompaniesResponseDTO
                {
                    companyLogin = x.CompanyLogin,
                    companyName = x.CompanyNameEn,
                    Id = x.Id
                }).FirstOrDefault();
            //var res = companies.Where(x => x.companyLogin == request.SearchCriteria ).FirstOrDefault();
            
            return new ResponseResult
            {
                Data = res,
                Result = res != null ? Result.Success : Result.Failed,
            };
        }
    }
}
