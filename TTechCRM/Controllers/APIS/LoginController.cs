using App.Api.Controllers.BaseController;
using App.Core.Handler.LoginSystem.Login;
using App.Core.Helper;
using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.APIs.Controllers.APIS
{
    public class LoginController : ApiControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IConfiguration _configuration;
        
        public LoginController(IMediator mediator, IConfiguration configuration)
        {
            _mediator = mediator;
            _configuration = configuration;
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(loginRequest request)
        {
            var res = await _mediator.Send(request);
            return Ok(res);
        }

        [Authorize]
        [HttpGet("GetTechincalSupportToken")]
        public async Task<IActionResult> GetTechincalSupportToken()
        {
            var tokenDecoded = ContextHelper.DecodingToken(HttpContext.Request.HttpContext.GetTokenAsync("access_token").Result);
            var userId = int.Parse(StringEncryption.DecryptString(tokenDecoded["userID"]));
            if (userId != -1)
                return Ok(new ResponseResult()
                {
                    Data = "Supper admin only allowed to get token"
                });
            var token = Helpers.generateSecretCode();
            ResponseResult res = new ResponseResult()
            {
                Data = token
            };
            return Ok(res);
        }

    }
}
