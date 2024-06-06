using App.Core.Handler.SystemLogs;
using App.Core.Helper;
using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using App.Infrastructure.ERPContext;
using App.Infrastructure.UserManagementDB;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.ReportsSystem
{
    public class ReplaceReportFileHandler : IRequestHandler<ReplaceReportFileRequest, ResponseResult>
    {
        private readonly IConfiguration _configuration;
        private readonly IMediator _mediator;

        public ReplaceReportFileHandler(IConfiguration configuration, IMediator mediator)
        {
            _configuration = configuration;
            _mediator = mediator;
        }
        public async Task<ResponseResult> Handle(ReplaceReportFileRequest request, CancellationToken cancellationToken)
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
            var screen = erpContext.ScreenNames.Where(x => x.Id == request.screenId).FirstOrDefault();
            var getExistFile = erpContext.ReportFiles.Where(x => x.Id == request.FileId).FirstOrDefault();
            if (getExistFile == null)
                return new ResponseResult
                {
                    ErrorMessageAr = ErrorMessagesAr.NoPrintFiles,
                    ErrorMessageEn = ErrorMessagesEN.NoPrintFiles,
                    Result = Result.NotFound
                };
            var oldFile = getExistFile.Files.CloneByteArray();
            getExistFile.Files = await FilesManager.GetBytes(request.newFiles);
            getExistFile.UTime = DateTime.Now;

            erpContext.Update(getExistFile);
            var saved = await erpContext.SaveChangesAsync();
            var userInfo = await _mediator.Send(new TokenRequest());

            await _mediator.Send(new SystemLogsRequest
            {
                actionId = (int)ERPReportsActions.Replace,
                companyId = request.companyId,
                EmployeesId = userInfo.employeeId,
                NewFile = await FilesManager.GetBytes(request.newFiles),
                Note = (request.isEdit ? "Edit " : "replace") + $" Report File Name :{getExistFile.ReportFileName} for screen {screen.ScreenNameEn} in Company {databaseName.CompanyLogin}",
                date = DateTime.Now,
                reportId = request.FileId,
                screenId = request.screenId,
                OldFile = oldFile
            });

            return new ResponseResult
            {
                Result = saved != 0 ? Result.Success : Result.Failed
            };
        }
    }
}
