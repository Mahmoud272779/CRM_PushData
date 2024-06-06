using App.Core.Helper;
using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using App.Infrastructure.ERPContext;
using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Handler.ERPBarcode
{
    public class DeleteBarcodeFileHandler : IRequestHandler<DeleteBarcodeFileRequest, ResponseResult>
    {
        private readonly IConfiguration _configuration;
        public DeleteBarcodeFileHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<ResponseResult> Handle(DeleteBarcodeFileRequest request, CancellationToken cancellationToken)
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
            var barcode = apexERPContext.BarcodePrintFiles.Where(c => c.Id == request.fileId).FirstOrDefault();
            apexERPContext.BarcodePrintFiles.Remove(barcode);
            var saved = apexERPContext.SaveChanges() > 0 ? true : false;
            return new ResponseResult
            {
                Result = saved ? Domain.Enums.Enums.Result.Success : Domain.Enums.Enums.Result.Failed
            };
        }
    }
}
