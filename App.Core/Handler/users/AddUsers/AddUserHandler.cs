using App.Domain.Entities;
using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using App.Infrastructure.Interfaces.Repository;
using MediatR;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.users
{
    public class AddUserHandler : IRequestHandler<AddUserRequest, ResponseResult>
    {
        private readonly IRepositoryQuery<Users> _usersQuery;
        private readonly IRepositoryCommand<Users> _usersCommand;

        public AddUserHandler(IRepositoryQuery<Users> usersQuery, IRepositoryCommand<Users> usersCommand)
        {
            _usersQuery = usersQuery;
            _usersCommand = usersCommand;
        }

        public async Task<ResponseResult> Handle(AddUserRequest request, CancellationToken cancellationToken)
        {
            var allUsers = _usersQuery.TableNoTracking;
            //check is user exist
            if (allUsers.Where(x => x.arabicName == request.arabicName).Any())
                return new ResponseResult
                {
                    ErrorMessageAr = ErrorMessagesAr.UserIsExist,
                    ErrorMessageEn = ErrorMessagesEN.UserIsExist,
                    Result = Result.Failed
                };
            var tableRow = new Users
            {
                arabicName = request.arabicName,
                employeesId = request.employeesId,
                isActive = request.isActive,
                latinName = request.latinName,
                password = request.password,
                permissionListId = request.permissionListId,
                username = request.username
            };
            var saved = await _usersCommand.AddAsync(tableRow);
            return new ResponseResult
            {
                Result = Result.Success
            };
        }
    }
}
