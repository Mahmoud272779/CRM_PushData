using App.Core.Helper;
using App.Domain.Entities;
using App.Domain.Models.Shared;
using App.Infrastructure.Interfaces.Repository;
using MediatR;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.Core.Handler.employees.GetAllEmployees
{
    public class getAllEmployeesHandler : IRequestHandler<getAllEmployeesRequest, ResponseResult>
    {
        private readonly IRepositoryQuery<Employees> _EmployeesQuery;
        private readonly IRepositoryCommand<Employees> _EmployeesCommand;

        public getAllEmployeesHandler(IRepositoryQuery<Employees> employeesQuery, IRepositoryCommand<Employees> employeesCommand)
        {
            _EmployeesQuery = employeesQuery;
            _EmployeesCommand = employeesCommand;
        }

        public async Task<ResponseResult> Handle(getAllEmployeesRequest request, CancellationToken cancellationToken)
        {
            var allEmployees = _EmployeesQuery.TableNoTracking;
            var count = allEmployees.Count();
            allEmployees = allEmployees.Where(x => !string.IsNullOrEmpty(request.SearchCriteria) ? x.arabicName.Contains(request.SearchCriteria) || x.latinName.Contains(request.SearchCriteria)  : true);
            var res = allEmployees.Skip((request.pageNumber - 1) * request.pageSize).Take(request.pageSize);
            return new ResponseResult
            {
                Data = res,
                DataCount = allEmployees.Count(),
                TotalCount = count,
                Note = PaginiationHelper.ReturnEndOfDataNote(request.pageNumber, request.pageSize, allEmployees.Count()),
            };
        }
    }
}
