using App.Domain.Models.Shared;
using MediatR;

namespace App.Core.Handler.ReportsSystem
{
    public class GetScreenFilesRequest : PaginiationDTO, IRequest<ResponseResult>
    {
        public int companyId { get; set; }
        public int screenId { get; set; }
        public string? SearchCriteria { get; set; }
    }
}
