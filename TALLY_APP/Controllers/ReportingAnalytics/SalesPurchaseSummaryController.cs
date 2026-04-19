using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReportingAnalytics.Services;
using ReportingAnalytics.DTOs.Request;
using ReportingAnalytics.DTOs.Response;

namespace TALLY_APP.Controllers.ReportingAnalytics
{
    /**
     * Controller: SalesPurchaseSummary
     *
     * Description:
     * Handles all CRUD operations for SalesPurchaseSummary module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("SalesPurchaseSummary")]
    public class SalesPurchaseSummaryController : Controller
    {
        private readonly ISalesPurchaseSummaryService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public SalesPurchaseSummaryController(ISalesPurchaseSummaryService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult Index() => View("~/Views/ReportingAnalytics/sales-purchase.cshtml");

        /**
         * Get all records
         *
         * @return List of SalesPurchaseSummary objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<SalesPurchaseSummaryResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of SalesPurchaseSummary objects
         */
        [HttpGet("api/index")]
        public async Task<ActionResult<List<SalesPurchaseSummaryResponse>>> ApiIndex()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single SalesPurchaseSummary object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<SalesPurchaseSummaryResponse>> View(long id)
        {
            return await _service.View(id);
        }

        /**
         * Create new record
         *
         * @param request Request body
         * @return Created record response
         */
        [HttpPost("create")]
        public async Task<ActionResult<SalesPurchaseSummaryResponse>> Create([FromBody] SalesPurchaseSummaryRequest request)
        {
            return await _service.Create(request);
        }

        /**
         * Update existing record
         *
         * @param id Record identifier
         * @param request Updated data
         * @return Updated record response
         */
        [HttpPut("update/{id}")]
        public async Task<ActionResult<SalesPurchaseSummaryResponse>> Update(long id, [FromBody] SalesPurchaseSummaryRequest request)
        {
            return await _service.Update(id, request);
        }

        /**
         * Delete record
         *
         * @param id Record identifier
         * @return Success message
         */
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _service.Delete(id);
            return Ok(new { message = "Deleted successfully" });
        }
    }
}
