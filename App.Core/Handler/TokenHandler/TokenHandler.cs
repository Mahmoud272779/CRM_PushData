using App.Core.Helper;
using App.Domain.Entities;
using App.Domain.Models.Response;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;

namespace App.Core.Handler.TokenHandler
{
    public class TokenHandler : IRequestHandler<TokenRequest, TokenHandlerResponse>
    {
        private readonly IHttpContextAccessor _httpContext;
        public TokenHandler(IHttpContextAccessor httpContext)
        {

            _httpContext = httpContext;

        }
        public async Task<TokenHandlerResponse> Handle(TokenRequest request, CancellationToken cancellationToken)
        {
            var token = await _httpContext.HttpContext.GetTokenAsync("access_token");
            var tokenDecoded = ContextHelper.DecodingToken(token);
            return new TokenHandlerResponse
            {
                employeeId = int.Parse(StringEncryption.DecryptString(tokenDecoded["employeeId"]))
            };
        }
    }
}
