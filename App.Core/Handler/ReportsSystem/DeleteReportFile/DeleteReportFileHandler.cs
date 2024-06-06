using App.Core.Handler.SystemLogs;
using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using App.Infrastructure.ERPContext;
using App.Infrastructure.UserManagementDB;
using MediatR;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography.X509Certificates;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.ReportsSystem
{
    public class DeleteReportFileHandler : IRequestHandler<DeleteReportFileRequest, ResponseResult>
    {
        private readonly IConfiguration _configuration;
        private readonly IMediator _mediator;

        public DeleteReportFileHandler(IConfiguration configuration, IMediator mediator)
        {
            _configuration = configuration;
            _mediator = mediator;
        }
        public async Task<ResponseResult> Handle(DeleteReportFileRequest request, CancellationToken cancellationToken)
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
            //check if screen exist
            var screen = erpContext.ScreenNames.Where(x=> x.Id == request.screenId).FirstOrDefault();
            var screenFiles = erpContext.ReportMangers.Where(x => x.ScreenId == request.screenId);
            if (screenFiles.Count() <= 1)
                return new ResponseResult
                {
                    ErrorMessageAr = ErrorMessagesAr.FilesCanNotBeLessThanOneFile,
                    ErrorMessageEn = ErrorMessagesEN.FilesCanNotBeLessThanOneFile,
                    Result = Result.Failed
                };
            var CurrentScreenFile = screenFiles.Where(x => x.ArabicFilenameId == request.fileId).FirstOrDefault();
            if (CurrentScreenFile == null)
                return new ResponseResult
                {
                    ErrorMessageAr = ErrorMessagesAr.FileIsNotExist,
                    ErrorMessageEn = ErrorMessagesEN.FileIsNotExist,
                    Result = Result.Failed
                };
            erpContext.ReportMangers.Remove(CurrentScreenFile);
            erpContext.SaveChanges();
            var fileRow = erpContext.ReportFiles.Where(x => x.Id == CurrentScreenFile.ArabicFilenameId).FirstOrDefault();
            var fileName = fileRow.ReportFileName;
            if (fileRow == null)
                return new ResponseResult
                {
                    ErrorMessageAr = ErrorMessagesAr.FileIsNotExist,
                    ErrorMessageEn = ErrorMessagesEN.FileIsNotExist,
                    Result = Result.Failed
                };
            var file = fileRow.Files;
            erpContext.ReportFiles.Remove(fileRow);
            var deleteReportFile = erpContext.SaveChanges();
            
                
                if (deleteReportFile != 0)
                {
                    var userInfo = await _mediator.Send(new TokenRequest());
                    await _mediator.Send(new SystemLogsRequest
                    {
                        actionId = (int)ERPReportsActions.delete,
                        companyId = request.companyId,
                        EmployeesId = userInfo.employeeId,
                        NewFile = file,
                        Note = $"Delete Report File Name : {fileName} for screen {screen.ScreenNameEn} in Company {getDatabaseName.CompanyLogin}",
                        date = DateTime.Now,
                        reportId = request.fileId,
                        screenId = request.screenId,
                    });
                    return new ResponseResult
                    {
                        Result = Result.Success
                    };
                }
                else
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
