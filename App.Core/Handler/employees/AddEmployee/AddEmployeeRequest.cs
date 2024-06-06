using App.Domain.Models.Request.Employees;
using App.Domain.Models.Shared;
using MediatR;

namespace App.Core.Handler.employees
{
    public class AddEmployeeRequest : AddEmployeesDTO,IRequest<ResponseResult>
    {
    }
}
