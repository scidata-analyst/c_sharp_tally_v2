using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.ReportingAnalytics;
using TALLY_APP.DTOs.Request.ReportingAnalytics;
using TALLY_APP.DTOs.Response.ReportingAnalytics;

namespace TALLY_APP.Controllers.ReportingAnalytics
{
    /**
     * Controller: CashFlowStatement
     *
     * Description:
     * Handles all CRUD operations for CashFlowStatement module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("CashFlowStatement")]
    public class CashFlowStatementController : Controller
    {
        private readonly ICashFlowStatementService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public CashFlowStatementController(ICashFlowStatementService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult Index() => View("~/Views/ReportingAnalytics/cashflow.cshtml");

        /**
         * Get all records
         *
         * @return List of CashFlowStatement objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<CashFlowStatementResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of CashFlowStatement objects
         */
        [HttpGet("api/index")]
        public async Task<ActionResult<List<CashFlowStatementResponse>>> ApiIndex()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single CashFlowStatement object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<CashFlowStatementResponse>> View(long id)
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
        public async Task<ActionResult<CashFlowStatementResponse>> Create([FromBody] CashFlowStatementRequest request)
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
        public async Task<ActionResult<CashFlowStatementResponse>> Update(long id, [FromBody] CashFlowStatementRequest request)
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

