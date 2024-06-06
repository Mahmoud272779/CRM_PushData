using App.Core.Handler.SystemLogs;
using App.Core.Helper;
using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using App.Infrastructure.ERPContext;
using MediatR;
using Microsoft.Extensions.Configuration;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.ERPBarcode
{
    public class addNewBarcodeFileHandler : IRequestHandler<addNewBarcodeFileRequest, ResponseResult>
    {
        private readonly IConfiguration _configuration;
        private readonly IMediator _mediator;
        public addNewBarcodeFileHandler(IConfiguration configuration, IMediator mediator)
        {
            _configuration = configuration;
            _mediator = mediator;
        }
        public async Task<ResponseResult> Handle(addNewBarcodeFileRequest request, CancellationToken cancellationToken)
        {
            ApexERPContext apexERPContext = ContextHelper.GetContext(_configuration, request.companyId);
            if (apexERPContext == null)
            {
                return new ResponseResult
                {
                    Result = Domain.Enums.Enums.Result.Failed,
                    ErrorMessageAr = ErrorMessagesAr.CompanyIsNotExist,
                    ErrorMessageEn = ErrorMessagesEN.CompanyIsNotExist,
                };
            }
            var row = new BarcodePrintFile
            {
                ArabicName = request.fileNameAr,
                LatineName = request.fileNameEn,
                IsDefault = false,
                File = await FilesManager.GetBytes(request.file)};
            apexERPContext.BarcodePrintFiles.Add(row);
            var saved = apexERPContext.SaveChanges() > 0?true:false;
            var userInfo = await _mediator.Send(new TokenRequest());
            await _mediator.Send(new SystemLogsRequest
            {
                actionId = (int)ERPReportsActions.Replace,
                companyId = request.companyId,
                EmployeesId = userInfo.employeeId,
                NewFile = await FilesManager.GetBytes(request.file),
                Note = $"Replace Barcode design Name: {request.fileNameAr} - {request.fileNameEn}",
                date = DateTime.Now,
                screenId = -1,
                reportId = row.Id,
                OldFile = await FilesManager.GetBytes(request.file),
            });
            return new ResponseResult
            {
                Result = saved ? Domain.Enums.Enums.Result.Success : Domain.Enums.Enums.Result.Failed
            };
        }
    }
}
