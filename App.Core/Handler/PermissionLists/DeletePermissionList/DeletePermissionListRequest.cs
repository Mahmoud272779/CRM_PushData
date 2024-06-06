using App.Domain.Models.Shared;
using MediatR;

namespace App.Core.Handler.PermissionLists
{
    public class DeletePermissionListRequest  : Delete,IRequest<ResponseResult>
    {
    }
}
