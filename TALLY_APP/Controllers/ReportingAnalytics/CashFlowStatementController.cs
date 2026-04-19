using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReportingAnalytics.Services;
using ReportingAnalytics.DTOs.Request;
using ReportingAnalytics.DTOs.Response;

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
    [Route("api/ReportingAnalytics/CashFlowStatement")]
    public class CashFlowStatementController : ControllerBase
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
        [HttpGet("index")]
        public async Task<ActionResult<List<CashFlowStatementResponse>>> Index()
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
