using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using App.Infrastructure.Interfaces.Repository;
using MediatR;
using Microsoft.Identity.Client;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.employees
{
    public class EditEmployeeHandler : IRequestHandler<EditEmployeeRequest, ResponseResult>
    {
        private readonly IRepositoryCommand<App.Domain.Entities.Employees> _EmployeesCommand;
        private readonly IRepositoryQuery<App.Domain.Entities.Employees> _EmployeesQuery;

        public EditEmployeeHandler(IRepositoryCommand<Domain.Entities.Employees> employeesCommand, IRepositoryQuery<Domain.Entities.Employees> employeesQuery)
        {
            _EmployeesCommand = employeesCommand;
            _EmployeesQuery = employeesQuery;
        }
        public async Task<ResponseResult> Handle(EditEmployeeRequest request, CancellationToken cancellationToken)
        {
            //check if the name valid 
            var allEmployees = _EmployeesQuery.TableNoTracking;
            if (allEmployees.Where(x => x.arabicName == request.arabicName && x.Id != request.Id).Any())
                return new ResponseResult
                {
                    ErrorMessageAr = ErrorMessagesAr.EmployeeIsExist,
                    ErrorMessageEn = ErrorMessagesEN.EmployeeIsExist,
                    Result = Result.Failed
                };
            var currentUser = allEmployees.Where(x => x.Id == request.Id).FirstOrDefault();
            if (currentUser == null)
                return new ResponseResult
                {
                    ErrorMessageAr = ErrorMessagesAr.EmployeeIsNotExist,
                    ErrorMessageEn = ErrorMessagesEN.EmployeeIsNotExist,
                    Result = Result.Failed
                };
            currentUser.arabicName = request.arabicName;
            currentUser.latinName = request.latinName;
            var edited = await _EmployeesCommand.UpdateAsyn(currentUser);
            return new ResponseResult
            {
                Result = edited ? Result.Success : Result.Failed
            };

        }
    }
}
