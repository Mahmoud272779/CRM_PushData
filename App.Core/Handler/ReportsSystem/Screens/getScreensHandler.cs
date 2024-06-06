using App.Core.Helper;
using App.Domain.Models.Response;
using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using App.Infrastructure.ERPContext;
using App.Infrastructure.UserManagementDB;
using MediatR;
using Microsoft.Extensions.Configuration;
using System.Data.Entity;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.ReportsSystem.Screens
{
    public class getScreensHandler : IRequestHandler<getScreensRequest, ResponseResult>
    {
        private readonly IConfiguration _configuration;
        public getScreensHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<ResponseResult> Handle(getScreensRequest request, CancellationToken cancellationToken)
        {
            var userManagerContext = new ErpUsersManagerContext(_configuration);
            var getDatabaseName = userManagerContext.UserApplications.Where(x => x.Id == request.companyId).FirstOrDefault();
            if (getDatabaseName == null)
                return new ResponseResult
                {
                    ErrorMessageAr = ErrorMessagesAr.CompanyIsNotExist,
                    ErrorMessageEn = ErrorMessagesEN.CompanyIsNotExist,
                    Result = Result.Failed
                };
            var erpContext = new ApexERPContext(_configuration, getDatabaseName.DatabaseName);
            var screensFromReportManager = erpContext.ReportFiles.Include(c=> c.ReportMangers).Where(c=> c.IsReport == request.isReport).Select(x => x.ReportMangers.FirstOrDefault().ScreenId).GroupBy(x => x).Select(x => x.FirstOrDefault());
            var screens = erpContext.ScreenNames.Where(x=> screensFromReportManager.Contains(x.Id)).Select(x => new ERPScreens
            {
                Id = x.Id,
                ScreenNameAr = x.ScreenNameAr,
                ScreenNameEn = x.ScreenNameEn
            });
            var Count = screens.Count();
            screens = screens.Where(x => !string.IsNullOrEmpty(request.SearchCriteria) ? x.ScreenNameEn.Contains(request.SearchCriteria) || x.ScreenNameEn.Contains(request.SearchCriteria) : true);
            var res = screens.Skip((request.pageNumber - 1) * request.pageSize).Take(request.pageSize);
            return new ResponseResult
            {
                Data = res,
                TotalCount = Count,
                DataCount = screens.Count(),
                Result = screens.Any() ? Result.Success : Result.NotFound,
                Note = PaginiationHelper.ReturnEndOfDataNote(request.pageNumber,request.pageSize, screens.Count())
            };
        }
    }
}
