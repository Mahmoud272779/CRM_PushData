using App.Domain.Models.Shared;
using MediatR;

namespace App.Core.Handler.employees
{
    public class DeleteEmployeeRequest : Delete,IRequest<ResponseResult>
    {
    }
}
