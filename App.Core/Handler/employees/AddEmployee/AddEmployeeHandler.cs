using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using App.Infrastructure.Interfaces.Repository;
using MediatR;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.employees
{
    public class AddEmployeeHandler : IRequestHandler<AddEmployeeRequest, ResponseResult>
    {
        private readonly IRepositoryCommand<App.Domain.Entities.Employees> _EmployeesCommand;
        private readonly IRepositoryQuery<App.Domain.Entities.Employees> _EmployeesQuery;
        public AddEmployeeHandler(IRepositoryQuery<Domain.Entities.Employees> employeesQuery, IRepositoryCommand<Domain.Entities.Employees> employeesCommand)
        {
            _EmployeesQuery = employeesQuery;
            _EmployeesCommand = employeesCommand;
        }
        public async Task<ResponseResult> Handle(AddEmployeeRequest request, CancellationToken cancellationToken)
        {
            //Check If Employee Exist
            if (_EmployeesQuery.TableNoTracking.Where(x => x.arabicName == request.arabicName).Any())
                return new ResponseResult
                {
                    ErrorMessageAr = ErrorMessagesAr.EmployeeIsExist,
                    ErrorMessageEn = ErrorMessagesEN.EmployeeIsExist,
                    Result = Result.Failed
                };
            var TableRow = new App.Domain.Entities.Employees()
            {
                arabicName = request.arabicName,
                latinName = request.latinName,
                Note = request.Note
            };
            var added = await _EmployeesCommand.AddAsync(TableRow);
            return new ResponseResult
            {
                Result = added ? Result.Success : Result.Failed
            };
        }
    }
}
