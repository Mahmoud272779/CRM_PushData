using App.Domain.Models.Shared;
using MediatR;

namespace App.Core.Handler.ReportsSystem.GetAllCompanies
{
    public class CompaniesRequest : IRequest<ResponseResult>
    {
        public string SearchCriteria { get; set; }
    }
}
