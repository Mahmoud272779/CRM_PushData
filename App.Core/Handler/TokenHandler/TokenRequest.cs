using App.Domain.Models.Response;
using MediatR;

namespace App.Core.Handler
{
    public class TokenRequest : IRequest<TokenHandlerResponse>
    {
    }
}
