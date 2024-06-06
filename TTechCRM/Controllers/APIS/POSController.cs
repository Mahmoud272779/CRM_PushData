using App.Api.Controllers.BaseController;
using App.Core.Handler.employees;
using App.Core.Handler.OfflinePOS.DeleteDeviceRegistrationService;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.APIs.Controllers.APIS
{
    public class POSController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public POSController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("DeleteDeviceActivation")]
        public async Task<IActionResult> DeleteDeviceActivation(DeleteDeviceRegistrationRequest request)
        {
            var res = await _mediator.Send(request);
            return Ok(res);
        }
    }
}
