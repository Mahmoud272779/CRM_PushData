using App.Domain.Models.Request.Users;
using App.Domain.Models.Shared;
using MediatR;

namespace App.Core.Handler.users
{
    public class AddUserRequest : AddUsersDTO,IRequest<ResponseResult>
    {
    }
}
