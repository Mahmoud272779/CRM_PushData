using App.Api.Controllers.BaseController;
using App.Core.Handler.employees;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.APIs.Controllers.APIS
{
    public class EmployeesController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployee(AddEmployeeRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("EditEmployee")]
        public async Task<IActionResult> EditEmployee(EditEmployeeRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("DeleteEmployee")]
        public async Task<IActionResult> DeleteEmployee(DeleteEmployeeRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("getAllEmployees")]
        public async Task<IActionResult> getAllEmployees(getAllEmployeesRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}
