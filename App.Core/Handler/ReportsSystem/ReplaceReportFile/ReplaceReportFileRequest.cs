using App.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace App.Core.Handler.ReportsSystem
{
    public class ReplaceReportFileRequest : IRequest<ResponseResult>
    {
        public int companyId { get; set; }
        public int screenId { get; set; }
        public int FileId { get; set; }
        public bool isEdit { get; set; } = false;
        public IFormFile newFiles { get; set; }

    }
}
