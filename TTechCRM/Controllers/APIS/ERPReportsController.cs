using App.Api.Controllers.BaseController;
using App.Core.Handler.ReportsSystem;
using App.Core.Handler.ReportsSystem.GetAllCompanies;
using App.Core.Handler.ReportsSystem.ReportHistory;
using App.Core.Handler.ReportsSystem.Screens;
using App.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.APIs.Controllers.APIS
{
    [ResponseCache(Duration = 60, Location = ResponseCacheLocation.None, NoStore = true)]
    public class ERPReportsController : ApiControllerBase
    {
        private readonly IMediator _mediator;
        public ERPReportsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCompanies")]
        public async Task<ResponseResult> GetCompanies([FromQuery]CompaniesRequest request)
        {
            return await _mediator.Send(request);
        }
        [HttpGet("getScreens")]
        public async Task<ResponseResult> getScreens([FromQuery] getScreensRequest request)
        {
            return await _mediator.Send(request);
        }
        [HttpGet("GetScreenFiles")]
        public async Task<ResponseResult> GetScreenFiles([FromQuery] GetScreenFilesRequest request)
        {
            return await _mediator.Send(request);
        }
        [HttpPost("ReplaceReportFile")]
        public async Task<ResponseResult> ReplaceReportFile([FromForm]ReplaceReportFileRequest request)
        {
            return await _mediator.Send(request);
        }
        [HttpPost("AddNewReportFile")]
        public async Task<ResponseResult> AddNewReportFile([FromForm]AddNewReportFileRequest request)
        {
            return await _mediator.Send(request);
        }
        [HttpPost("DeleteReportFile")]
        public async Task<ResponseResult> DeleteReportFile([FromQuery]DeleteReportFileRequest request)
        {
            return await _mediator.Send(request);
        }
        [HttpGet("ReportHistory")]
        public async Task<ResponseResult> ReportHistory([FromQuery] reporthistoryRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
