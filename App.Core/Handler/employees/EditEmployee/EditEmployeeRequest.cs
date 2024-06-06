using App.Domain.Models.Request.Employees;
using App.Domain.Models.Shared;
using MediatR;

namespace App.Core.Handler.employees
{
    public class EditEmployeeRequest : EditEmployeesDTO,IRequest<ResponseResult>
    {
    }
}
