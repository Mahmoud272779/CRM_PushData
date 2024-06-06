using App.Api.Controllers.BaseController;
using App.Core.Handler.ERPBarcode;
using App.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.APIs.Controllers.APIS
{
    public class ERPBarcodeController : ApiControllerBase
    {
        private readonly IMediator _mediator;
        public ERPBarcodeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("getERPBarcode")]
        public async Task<ResponseResult> getERPBarcode([FromQuery] getERPBarcodeRequest request)
        {
            return await _mediator.Send(request);
        }
        [HttpPost("AddNewBarcodeFile")]
        public async Task<ResponseResult> AddNewBarcodeFile([FromForm] addNewBarcodeFileRequest request)
        {
            return await _mediator.Send(request);
        }
        [HttpPost("DeleteBarcodeFile")]
        public async Task<ResponseResult> DeleteBarcodeFile([FromQuery] DeleteBarcodeFileRequest request)
        {
            return await _mediator.Send(request);
        }
        [HttpPost("ReplaceBarcodeFile")]
        public async Task<ResponseResult> ReplaceBarcodeFile([FromForm] ReplaceBarcodeFileRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
