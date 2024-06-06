using App.Domain.Entities;
using App.Infrastructure.Interfaces.Repository;
using MediatR;

namespace App.Core.Handler.SystemLogs
{
    public class SystemLogsHandler : IRequestHandler<SystemLogsRequest, bool>
    {
        private readonly IRepositoryCommand<SystemLogsHistory> _SystemLogsRequestcommand;

        public SystemLogsHandler(IRepositoryCommand<SystemLogsHistory> systemLogsRequestcommand)
        {
            _SystemLogsRequestcommand = systemLogsRequestcommand;
        }

        public async Task<bool> Handle(SystemLogsRequest request, CancellationToken cancellationToken)
        {
            var TableRow = new SystemLogsHistory
            {
                EmployeesId = request.EmployeesId,
                NewFile = request.NewFile,
                OldFile = request.OldFile,
                Note = request.Note,
                actionId = request.actionId,
                reportId = request.reportId,
                screenId = request.screenId,
                companyId = request.companyId,
                date = request.date
            };
            return await _SystemLogsRequestcommand.AddAsync(TableRow);
        }
    }
}
