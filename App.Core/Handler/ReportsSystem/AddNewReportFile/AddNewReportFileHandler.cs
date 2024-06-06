using App.Core.Handler.SystemLogs;
using App.Core.Helper;
using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using App.Infrastructure.ERPContext;
using App.Infrastructure.UserManagementDB;
using MediatR;
using Microsoft.Extensions.Configuration;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.ReportsSystem
{
    public class AddNewReportFileHandler : IRequestHandler<AddNewReportFileRequest, ResponseResult>
    {
        private readonly IConfiguration _configuration;
        private readonly IMediator _mediator;

        public AddNewReportFileHandler(IConfiguration configuration, IMediator mediator)
        {
            _configuration = configuration;
            _mediator = mediator;
        }

        public async Task<ResponseResult> Handle(AddNewReportFileRequest request, CancellationToken cancellationToken)
        {
            var userManagerContext = new ErpUsersManagerContext(_configuration);
            var databaseName = userManagerContext.UserApplications.Where(x => x.Id == request.companyId).FirstOrDefault();
            if (databaseName == null)
                return new ResponseResult
                {
                    ErrorMessageAr = ErrorMessagesAr.CompanyIsNotExist,
                    ErrorMessageEn = ErrorMessagesEN.CompanyIsNotExist,
                    Result = Result.NotFound
                };
            var erpContext = new ApexERPContext(_configuration, databaseName.DatabaseName);
            var checkIfScreenExist = erpContext.ScreenNames.Where(x => x.Id == request.screenId);
            if (!checkIfScreenExist.Any())
                return new ResponseResult
                {
                    ErrorMessageAr = ErrorMessagesAr.ScreenIsNotExist,
                    ErrorMessageEn = ErrorMessagesEN.ScreenIsNotExist,
                    Result = Result.NotFound
                };
            var reportFileRow = new ReportFile
            {
                Files = await FilesManager.GetBytes(request.Files),
                IsArabic = request.IsArabic,
                IsReport = request.IsReport,
                ReportFileName = request.ReportFileName,
                ReportFileNameAr = request.arabicName,
                UTime = DateTime.Now,
                IsDefault = false
            };
            erpContext.ReportFiles.Add(reportFileRow);
            var saved = erpContext.SaveChanges();
            if(saved != 0)
            {
                var reportManagerRow = new ReportManger
                {
                    ArabicFilenameId = reportFileRow.Id,
                    Copies = 1,
                    IsArabic = request.IsArabic,
                    ScreenId = request.screenId,
                    
                };
                erpContext.ReportMangers.Add(reportManagerRow);
                var saveReportManager = erpContext.SaveChanges();
                if(saveReportManager != 0)
                {
                    var userInfo = await _mediator.Send(new TokenRequest());
                    await _mediator.Send(new SystemLogsRequest
                    {
                        actionId = (int)ERPReportsActions.addNew,
                        companyId = request.companyId,
                        EmployeesId = userInfo.employeeId,
                        NewFile = await FilesManager.GetBytes(request.Files),
                        Note = $"Add a new Report Name: {request.ReportFileName},File for screen {checkIfScreenExist.FirstOrDefault().ScreenNameEn}",
                        date = DateTime.Now,
                        reportId = reportManagerRow.Id,
                        screenId = request.screenId,
                        OldFile = await FilesManager.GetBytes(request.Files)
                    });
                    return new ResponseResult
                    {
                        Result = Result.Success
                    };
                }
                else
                {
                    erpContext.ReportFiles.Remove(reportFileRow);
                    erpContext.SaveChanges();
                    return new ResponseResult
                    {
                        ErrorMessageAr = ErrorMessagesAr.ErrorWhileSaving,
                        ErrorMessageEn = ErrorMessagesEN.ErrorWhileSaving,
                        Result = Result.Failed
                    };
                }
            }
            {
                return new ResponseResult
                {
                    ErrorMessageAr = ErrorMessagesAr.ErrorWhileSaving,
                    ErrorMessageEn = ErrorMessagesEN.ErrorWhileSaving,
                    Result = Result.Failed
                };
            }
            


            }
    }
}
