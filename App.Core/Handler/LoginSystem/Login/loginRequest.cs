using App.Domain.Models.Request.Login;
using App.Domain.Models.Shared;
using MediatR;

namespace App.Core.Handler.LoginSystem.Login
{
    public class loginRequest : LoginRequest,IRequest<ResponseResult>
    {
    }
}
