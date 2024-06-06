using App.Domain.Entities;
using App.Domain.Models.Shared;
using App.Infrastructure.Interfaces.Repository;
using MediatR;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.users
{
    public class DeleteUsersHandler : IRequestHandler<DeleteUsersRequest, ResponseResult>
    {
        private readonly IRepositoryQuery<Users> _UsersQuery;
        private readonly IRepositoryCommand<Users> _UsersCommand;
        public DeleteUsersHandler(IRepositoryQuery<Users> usersQuery, IRepositoryCommand<Users> usersCommand)
        {
            _UsersQuery = usersQuery;
            _UsersCommand = usersCommand;
        }

        public async Task<ResponseResult> Handle(DeleteUsersRequest request, CancellationToken cancellationToken)
        {
            var users = _UsersQuery.TableNoTracking.Where(x => request.ids.Contains(x.Id));
            if (!users.Any())
                new ResponseResult
                {
                    Result = Result.NotFound
                };
            _UsersCommand.RemoveRange(users);
            var deleted = await _UsersCommand.SaveAsync();
            return new ResponseResult
            {
                Result = deleted ? Result.Success : Result.Failed
            };
        }
    }
}
