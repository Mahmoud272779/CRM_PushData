using App.Api.Controllers.BaseController;
using App.Core.Handler;
using App.Core.Handler.users;
using App.Core.Helper;
using App.Core.Services.PushDataChain;
using App.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.APIs.Controllers.APIS
{
	public class usersController : ApiControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IConfiguration _configuration;
		private readonly IRestfulAPIService _restfulAPIService;
		public usersController(IMediator mediator, IConfiguration configuration, IRestfulAPIService restfulAPIService)
		{
			_mediator = mediator;
			_configuration = configuration;
			_restfulAPIService = restfulAPIService;
		}
		[HttpPost("AddUsers")]
        public async Task<IActionResult> AddUsers(AddUserRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("EditUsers")]
        public async Task<IActionResult> EditUsers(EditUsersRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("DeleteUsers")]
        public async Task<IActionResult> DeleteUsers(DeleteUsersRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers(GetAllUsersRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [AllowAnonymous]
		[HttpPost("testtt")]
		public async Task<IActionResult> testtt()
		{
            IPushDataChain pp=new PushDataChain(_restfulAPIService,_configuration);
            await pp.IPush();
			return Ok();
		}

	}
    public class itemsBarcode
    {
        public int designId { get; set; }
        public bool isInvoice { get; set; }
        public List<itemsBarcodeDetalies> data { get; set; }

    }
    public class itemsBarcodeDetalies
    {
        public int itemId { get; set; }
        public int count { get; set; }
        public DateTime expairDate { get; set; }
        public int ivoiceDetaliesId { get; set; }
        

    }
}
