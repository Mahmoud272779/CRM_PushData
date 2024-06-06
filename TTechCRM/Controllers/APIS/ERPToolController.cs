using App.Api.Controllers.BaseController;
using App.Core.Handler.ERPTool.DeleteData;
using App.Core.Handler.ERPTool.ReCreateCustomerFA;
using App.Core.Handler.ERPTool.ReCreateJournalEntry;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.APIs.Controllers.APIS
{
    public class ERPToolController : ApiControllerBase
    {
        public ERPToolController(IMediator mediator) : base(mediator)
        {
        }

        /// <remarks>
        /// customer = 1,
        /// supplier = 2
        /// </remarks>
        [HttpPost(nameof(ReCreateCustomerSupplierFA))]
        public async Task<IActionResult> ReCreateCustomerSupplierFA([FromBody] ReCreateCustomerSupplierFARequest request)
        {
            var res = await CommandAsync(request);
            return Ok(res);
        }
        /// <remarks>
        /// entryFund = 1,
        /// puchases = 2,
        /// sales = 3,
        /// pos = 4,
        /// recsAndSettlements = 5
        /// </remarks>
        [HttpPost(nameof(ReCreateInvoiceJournalEntry))]
        public async Task<IActionResult> ReCreateInvoiceJournalEntry([FromBody] ReCreateJournalEntryRequest request)
        {
            var res = await CommandAsync(request);
            return Ok(res);
        }

        /// <remarks>
        /// MainData=0,
        /// Doc = 1
        /// </remarks>
        [HttpPost(nameof(DeleteData))]
        public async Task<IActionResult> DeleteData([FromBody] DeleteDataRequest request)
        {
            var res = await CommandAsync(request);
            return Ok(res);
        }
    }
}
