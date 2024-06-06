using App.Domain.Entities;
using MediatR;

namespace App.Core.Handler.SystemLogs
{
    public class SystemLogsRequest : SystemLogsHistory,IRequest<bool>
    {
    }
}
