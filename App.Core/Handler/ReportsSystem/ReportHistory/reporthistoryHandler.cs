using App.Domain.Entities;
using App.Domain.Models.Response;
using App.Domain.Models.Shared;
using App.Infrastructure.Interfaces.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Handler.ReportsSystem.ReportHistory
{
    public class reporthistoryHandler : IRequestHandler<reporthistoryRequest, ResponseResult>
    {
        private readonly IRepositoryQuery<SystemLogsHistory> _SystemLogsHistoryQuery;
        public reporthistoryHandler(IRepositoryQuery<SystemLogsHistory> systemLogsHistoryQuery)
        {
            _SystemLogsHistoryQuery = systemLogsHistoryQuery;
        }

        public async Task<ResponseResult> Handle(reporthistoryRequest request, CancellationToken cancellationToken)
        {
            var logs = _SystemLogsHistoryQuery.TableNoTracking
                        .Include(x=> x.Employees)
                        .Where(x => x.companyId == request.companyId && x.screenId == request.screenId)
                        .Select(x=> new reportHistoryResponse
                        {
                            Id = x.Id,
                            date = x.date,
                            employeeArabicName = x.Employees.arabicName,
                            note = x.Note,
                            newFile = x.NewFile,
                            oldFile = x.OldFile
                        });
            return new ResponseResult
            {
                Data = logs
            };

        }
    }
}
