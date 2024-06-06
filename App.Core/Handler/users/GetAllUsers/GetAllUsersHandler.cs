using App.Core.Helper;
using App.Domain.Entities;
using App.Domain.Models.Shared;
using App.Infrastructure.Interfaces.Repository;
using MediatR;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.users
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersRequest, ResponseResult>
    {
        private readonly IRepositoryQuery<Users> _UsersQuery;

        public GetAllUsersHandler(IRepositoryQuery<Users> usersQuery)
        {
            _UsersQuery = usersQuery;
        }

        public async Task<ResponseResult> Handle(GetAllUsersRequest request, CancellationToken cancellationToken)
        {
            var allUsers = _UsersQuery.TableNoTracking;
            var count = allUsers.Count();
            allUsers = allUsers.Where(x => !string.IsNullOrEmpty(request.SearchCriteria) ? (x.arabicName.Contains(request.SearchCriteria) || x.latinName.Contains(request.SearchCriteria)) : true);
            var res = allUsers.Skip((request.pageNumber - 1) * request.pageSize).Take(request.pageSize);
            return new ResponseResult
            {
                Result = allUsers.Any() ? Result.Success : Result.NotFound,
                Data = res,
                DataCount = allUsers.Count(),
                TotalCount = count,
                Note = PaginiationHelper.ReturnEndOfDataNote(request.pageNumber,request.pageSize,count)
            };
        }
    }
}
