using App.Domain.Models.Request.PermissionList;
using App.Domain.Models.Shared;
using MediatR;

namespace App.Core.Handler.PermissionLists.AddPermissionList
{
    public class AddPermissionListRequest : AddPermissionListRequestDTO, IRequest<ResponseResult>
    {

    }
}
