using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReportingAnalytics.Services;
using ReportingAnalytics.DTOs.Request;
using ReportingAnalytics.DTOs.Response;

namespace TALLY_APP.Controllers.ReportingAnalytics
{
    /**
     * Controller: BalanceSheet
     *
     * Description:
     * Handles all CRUD operations for BalanceSheet module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("api/ReportingAnalytics/BalanceSheet")]
    public class BalanceSheetController : ControllerBase
    {
        private readonly IBalanceSheetService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public BalanceSheetController(IBalanceSheetService service)
        {
            _service = service;
        }

        /**
         * Get all records
         *
         * @return List of BalanceSheet objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<BalanceSheetResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of BalanceSheet objects
         */
        [HttpGet("index")]
        public async Task<ActionResult<List<BalanceSheetResponse>>> Index()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single BalanceSheet object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<BalanceSheetResponse>> View(long id)
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
        public async Task<ActionResult<BalanceSheetResponse>> Create([FromBody] BalanceSheetRequest request)
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
        public async Task<ActionResult<BalanceSheetResponse>> Update(long id, [FromBody] BalanceSheetRequest request)
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
