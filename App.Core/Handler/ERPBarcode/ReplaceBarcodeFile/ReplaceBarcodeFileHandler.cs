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
    public class ReplaceBarcodeFileHandler : IRequestHandler<ReplaceBarcodeFileRequest, ResponseResult>
    {
        private readonly IConfiguration _configuration;
        private readonly IMediator _mediator;
        public ReplaceBarcodeFileHandler(IConfiguration configuration, IMediator mediator)
        {
            _configuration = configuration;
            _mediator = mediator;
        }
        public async Task<ResponseResult> Handle(ReplaceBarcodeFileRequest request, CancellationToken cancellationToken)
        {
            ApexERPContext apexERPContext = ContextHelper.GetContext(_configuration, request.companyId);
            if (apexERPContext == null)
            {
                return new ResponseResult
                {
                    Result = Result.Failed,
                    ErrorMessageAr = ErrorMessagesAr.CompanyIsNotExist,
                    ErrorMessageEn = ErrorMessagesEN.CompanyIsNotExist,
                };
            }
            var barcode = apexERPContext.BarcodePrintFiles.Where(c => c.Id == request.fileId).FirstOrDefault();
            var oldFile = barcode.File;
            barcode.File = await FilesManager.GetBytes(request.file);
            var saved = await apexERPContext.SaveChangesAsync();
            var userInfo = await _mediator.Send(new TokenRequest());
            await _mediator.Send(new SystemLogsRequest
            {
                actionId = (int)ERPReportsActions.Replace,
                companyId = request.companyId,
                EmployeesId = userInfo.employeeId,
                NewFile = await FilesManager.GetBytes(request.file),
                Note = $"Replace Barcode design Name: {barcode.ArabicName}",
                date = DateTime.Now,    
                screenId = -1,
                reportId = request.fileId,
                OldFile = oldFile
            });
            return new ResponseResult
            {
                Result = Result.Success 
            };
        }
    }
}
