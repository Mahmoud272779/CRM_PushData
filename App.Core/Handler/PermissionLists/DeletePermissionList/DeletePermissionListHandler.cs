using App.Domain.Entities;
using App.Domain.Models.Shared;
using App.Infrastructure.Interfaces.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.PermissionLists
{
    public class DeletePermissionListHandler : IRequestHandler<DeletePermissionListRequest, ResponseResult>
    {
        private readonly IRepositoryCommand<PermissionList> _PermissionListCommand;
        private readonly IRepositoryQuery<PermissionList> _PermissionListQuery;

        public DeletePermissionListHandler(IRepositoryCommand<PermissionList> permissionListCommand, IRepositoryQuery<PermissionList> permissionListQuery)
        {
            _PermissionListCommand = permissionListCommand;
            _PermissionListQuery = permissionListQuery;
        }

        public async Task<ResponseResult> Handle(DeletePermissionListRequest request, CancellationToken cancellationToken)
        {
            var findRows = _PermissionListQuery.TableNoTracking.Where(x => request.ids.Contains(x.Id));
            _PermissionListCommand.RemoveRange(findRows);
            var deleted = await _PermissionListCommand.SaveAsync();
            return new ResponseResult
            {
                Result = deleted ? Result.Success : Result.Failed
            };
        }
    }
}
