using App.Domain.Models.Shared;
using MediatR;

namespace App.Core.Handler.PermissionLists.GetAllPermissionList
{
    public class GetAllPermissionListRequest : PaginiationDTO, IRequest<ResponseResult>
    {
    }
}
