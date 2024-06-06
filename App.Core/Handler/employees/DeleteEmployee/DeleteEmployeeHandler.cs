using App.Domain.Models.Shared;
using App.Infrastructure.Interfaces.Repository;
using MediatR;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.employees
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeRequest, ResponseResult>
    {
        private readonly IRepositoryCommand<App.Domain.Entities.Employees> _EmployeesCommand;
        private readonly IRepositoryQuery<App.Domain.Entities.Employees> _EmployeesQuery;

        public DeleteEmployeeHandler(IRepositoryCommand<Domain.Entities.Employees> employeesCommand, IRepositoryQuery<Domain.Entities.Employees> employeesQuery)
        {
            _EmployeesCommand = employeesCommand;
            _EmployeesQuery = employeesQuery;
        }

        public async Task<ResponseResult> Handle(DeleteEmployeeRequest request, CancellationToken cancellationToken)
        {
            var employees = _EmployeesQuery.TableNoTracking.Where(x => request.ids.Contains(x.Id));
            _EmployeesCommand.RemoveRange(employees);
            var deleted = await _EmployeesCommand.SaveAsync();
            return new ResponseResult
            {
                Result = deleted ? Result.Success : Result.Failed
            };
        }
    }
}
