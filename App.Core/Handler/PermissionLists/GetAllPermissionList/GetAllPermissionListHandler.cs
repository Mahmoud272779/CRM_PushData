using App.Core.Helper;
using App.Domain.Entities;
using App.Domain.Models.Shared;
using App.Infrastructure.Interfaces.Repository;
using MediatR;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.PermissionLists.GetAllPermissionList
{
    public class GetAllPermissionListHandler : IRequestHandler<GetAllPermissionListRequest, ResponseResult>
    {
        private readonly IRepositoryQuery<PermissionList> _PermissionListQuery;

        public GetAllPermissionListHandler(IRepositoryQuery<PermissionList> permissionListQuery)
        {
            _PermissionListQuery = permissionListQuery;
        }

        public async Task<ResponseResult> Handle(GetAllPermissionListRequest request, CancellationToken cancellationToken)
        {
            var allPermissionList = _PermissionListQuery.TableNoTracking;
            var count = allPermissionList.Count();
            var res = allPermissionList.Skip((request.pageNumber - 1 ) * request.pageSize).Take(request.pageSize);
            return new ResponseResult
            {
                Data = res,
                Result = res.Any() ? Result.Success : Result.Failed,
                Note = PaginiationHelper.ReturnEndOfDataNote(request.pageNumber,request.pageSize,count)
            };
        }
    }
}
