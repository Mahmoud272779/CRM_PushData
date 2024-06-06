using App.Domain.Models.Shared;
using MediatR;

namespace App.Core.Handler.ReportsSystem.Screens
{
    public class getScreensRequest : PaginiationDTO,IRequest<ResponseResult>
    {
        public int companyId { get; set; }
        public string? SearchCriteria { get; set; }
        public int isReport { get; set; }
    }
}
