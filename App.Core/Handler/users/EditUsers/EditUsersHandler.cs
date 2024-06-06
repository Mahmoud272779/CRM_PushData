using App.Domain.Entities;
using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using App.Infrastructure.Interfaces.Repository;
using MediatR;
using System.Security.Cryptography.X509Certificates;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.users
{
    public class EditUsersHandler : IRequestHandler<EditUsersRequest, ResponseResult>
    {
        private readonly IRepositoryQuery<Users> _UsersQuery;
        private readonly IRepositoryCommand<Users> _UsersCommand;
        public EditUsersHandler(IRepositoryQuery<Users> usersQuery, IRepositoryCommand<Users> usersCommand)
        {
            _UsersQuery = usersQuery;
            _UsersCommand = usersCommand;
        }

        public async Task<ResponseResult> Handle(EditUsersRequest request, CancellationToken cancellationToken)
        {
            var allUsers = _UsersQuery.TableNoTracking;
            if (allUsers.Where(x => x.arabicName == request.arabicName && x.Id != request.Id).Any())
                return new ResponseResult
                {
                    ErrorMessageAr = ErrorMessagesAr.UserIsExist,
                    ErrorMessageEn = ErrorMessagesEN.UserIsExist,
                    Result = Result.Failed
                };
            var currentUser = allUsers.Where(x => x.Id == request.Id).FirstOrDefault();
            if (currentUser != null)
                return new ResponseResult
                {
                    ErrorMessageAr = ErrorMessagesAr.UserIsNotExist,
                    ErrorMessageEn = ErrorMessagesEN.UserIsNotExist,
                    Result = Result.Failed
                };
            currentUser.arabicName = request.arabicName;
            currentUser.latinName = request.latinName;
            currentUser.employeesId = request.employeesId;
            currentUser.isActive = request.isActive;
            currentUser.password = request.password;
            currentUser.permissionListId = request.permissionListId;
            currentUser.username = request.username;
            var edited = await _UsersCommand.UpdateAsyn(currentUser);
            return new ResponseResult
            {
                Result = edited ? Result.Success : Result.Success
            };
        }
    }
}
