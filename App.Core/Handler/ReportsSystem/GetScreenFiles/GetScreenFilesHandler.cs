using App.Domain.Entities;
using App.Domain.Models.Response;
using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using App.Infrastructure.ERPContext;
using App.Infrastructure.Interfaces.Repository;
using App.Infrastructure.UserManagementDB;
using MediatR;
using Microsoft.Extensions.Configuration;
using System.Data.Entity;
using System.Web.Http;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.ReportsSystem
{
    public class GetScreenFilesHandler : IRequestHandler<GetScreenFilesRequest, ResponseResult>
    {
        private readonly IConfiguration _configuration;
        private readonly IRepositoryQuery<SystemLogsHistory> _SystemLogsHistoryQuery;
        public GetScreenFilesHandler(IConfiguration configuration, IRepositoryQuery<SystemLogsHistory> systemLogsHistoryQuery)
        {
            _configuration = configuration;
            _SystemLogsHistoryQuery = systemLogsHistoryQuery;
        }
        public async Task<ResponseResult> Handle(GetScreenFilesRequest request, CancellationToken cancellationToken)
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
            var ScreenFiles = erpContext.ReportMangers.AsNoTracking()
                                                      .Include(x => x.ArabicFilename)
                                                      .Where(x => x.ScreenId == request.screenId)
                                                      .Select(x => new ReportFilesResponseDTO
                                                      {
                                                          Id = x.ArabicFilename.Id,
                                                          Files = x.ArabicFilename.Files,
                                                          IsReport = x.ArabicFilename.IsReport,
                                                          IsArabic = x.ArabicFilename.IsArabic,
                                                          fileName = x.ArabicFilename.ReportFileName
                                                      });
            if (!ScreenFiles.Any())
                return new ResponseResult
                {
                    ErrorMessageAr = ErrorMessagesAr.NoPrintFiles,
                    ErrorMessageEn = ErrorMessagesEN.NoPrintFiles,
                    Result = Result.NotFound
                };
            var count = ScreenFiles.Count();

            ScreenFiles = ScreenFiles.Where(x => !string.IsNullOrEmpty(request.SearchCriteria) ? x.fileName.Contains(request.SearchCriteria) : true);

            var logs = _SystemLogsHistoryQuery.TableNoTracking.Where(x => x.companyId == request.companyId && x.screenId == request.screenId).ToList();

            var res = ScreenFiles.Skip((request.pageNumber - 1) * request.pageSize).Take(request.pageSize).ToList()
                .Select(x=> new
                {
                    x.Id,
                    x.IsArabic,
                    x.IsReport,
                    x.fileName,
                    x.Files,
                    contOfEdited = logs.Where(c=> c.reportId == x.Id).Count()
                });
            return new ResponseResult
            {
                Data = res,
                TotalCount = count,
                DataCount = ScreenFiles.Count(),
                Result = count > 0 ? Result.Success : Result.Failed
            };
        }
    }
}
