using App.Domain.Entities;

using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using App.Infrastructure.Interfaces.Repository;
using MediatR;
using System.Data.Entity;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.LoginSystem.Login
{
    public class LoginHandler : IRequestHandler<loginRequest, ResponseResult>
    {
        private readonly IRepositoryQuery<Users> _usersQuery;
        private readonly IRepositoryQuery<Employees> _EmployeesQuery;
        private readonly IRepositoryQuery<PermissionList> _PermissionListQuery;

        public LoginHandler(IRepositoryQuery<Employees> employeesQuery, IRepositoryQuery<Users> usersQuery, IRepositoryQuery<PermissionList> permissionListQuery)
        {
            _EmployeesQuery = employeesQuery;
            _usersQuery = usersQuery;
            _PermissionListQuery = permissionListQuery;
        }

        public LoginHandler(IRepositoryQuery<Users> usersQuery)
        {
            _usersQuery = usersQuery;
        }

        public async Task<ResponseResult> Handle(loginRequest request, CancellationToken cancellationToken)
        {
            await _usersQuery.migration();
            var findUser = _usersQuery.TableNoTracking.Include(x => x.employees).Include(x => x.permissionList).Where(x => x.username == request.userName && x.password == request.Password);
            if (!findUser.Any())
                return new ResponseResult
                {
                    ErrorMessageAr = ErrorMessagesAr.FaildLoginUserNameOrPasswordAreWrong,
                    ErrorMessageEn = ErrorMessagesEN.FaildLoginUserNameOrPasswordAreWrong,
                    Result = Result.Failed
                };
            if (!findUser.FirstOrDefault().isActive)
                return new ResponseResult
                {
                    ErrorMessageAr = ErrorMessagesAr.userIsNotActive,
                    ErrorMessageEn = ErrorMessagesEN.userIsNotActive,
                    Result = Result.Failed
                };
            var user = findUser.FirstOrDefault();
            var employee = _EmployeesQuery.TableNoTracking.Where(x => x.Id == user.employeesId).FirstOrDefault();
            var permission = _PermissionListQuery.TableNoTracking.Where(x => x.Id == user.permissionListId).FirstOrDefault();
            var auth = await JWTGeneration.getAuthToken(employee.Id.ToString(), user.Id, user.permissionListId.ToString());
            auth.arabicName = employee.arabicName;
            auth.latinName = employee.latinName;
            auth.userName = user.username;
            auth.permissionNameEn = permission.latinName;
            auth.permissionNameAr = permission.arabicName;
            return new ResponseResult
            {
                Data = auth,
                Result = Result.Success
            };
        }
    }
}
