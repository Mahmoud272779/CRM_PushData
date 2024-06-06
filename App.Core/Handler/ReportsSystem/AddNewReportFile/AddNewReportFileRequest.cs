using App.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace App.Core.Handler.ReportsSystem
{
    public class AddNewReportFileRequest : IRequest<ResponseResult>
    {
        public int companyId { get; set; }
        public int screenId { get; set; }
        public string? ReportFileName { get; set; }
        public string? arabicName { get; set; }
        public bool IsArabic { get; set; }
        public int IsReport { get; set; }
        public IFormFile? Files { get; set; }
    }
}
