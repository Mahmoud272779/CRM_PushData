using App.Api.Controllers.BaseController;
using App.Core.Handler.PermissionLists;
using App.Core.Handler.PermissionLists.AddPermissionList;
using App.Core.Handler.PermissionLists.EditPermission;
using App.Core.Handler.PermissionLists.GetAllPermissionList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.APIs.Controllers.APIS
{
    public class PermissionListController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public PermissionListController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("AddPermissionList")]
        public async Task<IActionResult> AddPermissionList(AddPermissionListRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("EditPermissionList")]
        public async Task<IActionResult> EditPermissionList(EditPermissionRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("DeletePermissionList")]
        public async Task<IActionResult> DeletePermissionList(DeletePermissionListRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("GetAllPermissionList")]
        public async Task<IActionResult> GetAllPermissionList(GetAllPermissionListRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}
