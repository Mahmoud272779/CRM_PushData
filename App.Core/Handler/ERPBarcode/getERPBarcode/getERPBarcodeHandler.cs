using App.Core.Helper;
using App.Domain.Entities;
using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using App.Infrastructure.ERPContext;
using App.Infrastructure.Interfaces.Repository;
using App.Infrastructure.UserManagementDB;
using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Handler.ERPBarcode
{
    public class getERPBarcodeHandler : IRequestHandler<getERPBarcodeRequest, ResponseResult>
    {
        private readonly IMediator _mediator;
        private readonly IConfiguration _configuration;
        private readonly IRepositoryQuery<SystemLogsHistory> _SystemLogsHistoryQuery;

        public getERPBarcodeHandler(IMediator mediator, IConfiguration configuration, IRepositoryQuery<SystemLogsHistory> systemLogsHistoryQuery)
        {
            _mediator = mediator;
            _configuration = configuration;
            _SystemLogsHistoryQuery = systemLogsHistoryQuery;
        }
        public async Task<ResponseResult> Handle(getERPBarcodeRequest request, CancellationToken cancellationToken)
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
            var editItems = _SystemLogsHistoryQuery.TableNoTracking.Where(c => c.screenId == -1);
            var barcodes = apexERPContext.BarcodePrintFiles.ToList()
                .Select(c => new getERPBarcodeResponseObject
            {
                Id = c.Id,
                ArabicName = c.ArabicName,
                LatineName = c.LatineName,
                File = c.File,
                IsDefault = c.IsDefault,
                editCount = editItems.Where(s => s.reportId == c.Id).Count()
            });

            return new ResponseResult
            {
                Data = barcodes,
                Result = Domain.Enums.Enums.Result.Success
            };
        }
    }
    public class getERPBarcodeResponseObject
    {
        public int Id { get; set; }

        public string? ArabicName { get; set; }

        public string? LatineName { get; set; }

        public byte[]? File { get; set; }

        public bool IsDefault { get; set; }
        public int editCount { get; set; }
    }
}
