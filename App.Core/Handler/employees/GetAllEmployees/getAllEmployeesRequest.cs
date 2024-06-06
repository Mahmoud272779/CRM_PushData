using App.Domain.Models.Shared;
using MediatR;

namespace App.Core.Handler.employees
{
    public class getAllEmployeesRequest : PaginiationDTO,IRequest<ResponseResult>
    {
        public string SearchCriteria { get; set; }
    }
}
