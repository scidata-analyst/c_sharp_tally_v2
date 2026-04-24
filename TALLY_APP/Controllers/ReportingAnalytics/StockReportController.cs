using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.ReportingAnalytics;
using TALLY_APP.DTOs.Response.ReportingAnalytics;

namespace TALLY_APP.Controllers.ReportingAnalytics
{
     
    
    [Route("StockReport")]
    [ApiController]
    public class StockReportController : Controller
    {
        [HttpGet("")]
        public IActionResult Index() => View("~/Views/ReportingAnalytics/stock-reports.cshtml");

        private readonly IStockReportService _service;
        public StockReportController(IStockReportService service) => _service = service;

        [HttpGet("api/index")]
        public async Task<ActionResult<PaginatedStockReportResponse>> ApiIndex([FromQuery] int page = 1, [FromQuery] int pageSize = 10, [FromQuery] string search = "", [FromQuery] string sortColumn = "Id", [FromQuery] string sortDirection = "asc")
            => await _service.Index(page, pageSize, search, sortColumn, sortDirection);
    }
}











