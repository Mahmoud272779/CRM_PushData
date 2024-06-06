using App.Domain.Models.Shared;
using MediatR;

namespace App.Core.Handler.users
{
    public class DeleteUsersRequest : Delete,IRequest<ResponseResult>
    {
    }
}
