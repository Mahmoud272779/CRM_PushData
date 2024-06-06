using App.Domain.Models.Shared;
using MediatR;

namespace App.Core.Handler.ReportsSystem
{
    public class DeleteReportFileRequest : IRequest<ResponseResult>
    {
        public int companyId { get; set; }
        public int fileId { get; set; }
        public int screenId { get; set; }

    }
}
