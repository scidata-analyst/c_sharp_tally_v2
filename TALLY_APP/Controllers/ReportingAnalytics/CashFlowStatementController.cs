using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.ReportingAnalytics;
using TALLY_APP.DTOs.Response.ReportingAnalytics;

namespace TALLY_APP.Controllers.ReportingAnalytics
{
     
    
    [Route("CashFlowStatement")]
    [ApiController]
    public class CashFlowStatementController : Controller
    {
        [HttpGet("")]
        public IActionResult Index() => View("~/Views/ReportingAnalytics/cashflow.cshtml");

        private readonly ICashFlowStatementService _service;
        public CashFlowStatementController(ICashFlowStatementService service) => _service = service;

        [HttpGet("api/index")]
        public async Task<ActionResult<PaginatedCashFlowStatementResponse>> ApiIndex([FromQuery] int page = 1, [FromQuery] int pageSize = 10, [FromQuery] string search = "", [FromQuery] string sortColumn = "Id", [FromQuery] string sortDirection = "desc")
            => await _service.Index(page, pageSize, search, sortColumn, sortDirection);
    }
}











