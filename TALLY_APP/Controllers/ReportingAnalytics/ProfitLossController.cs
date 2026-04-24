using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.ReportingAnalytics;
using TALLY_APP.DTOs.Request.ReportingAnalytics;
using TALLY_APP.DTOs.Response.ReportingAnalytics;

namespace TALLY_APP.Controllers.ReportingAnalytics
{
    /**
     * Controller: ProfitLoss
     *
     * Description:
     * Handles all CRUD operations for ProfitLoss module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("api/ReportingAnalytics/ProfitLoss")]
    public class ProfitLossController : Controller
    {
        private readonly IProfitLossService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public ProfitLossController(IProfitLossService service)
        {
            _service = service;
        }

        /**
         * Get all records
         *
         * @return List of ProfitLoss objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<ProfitLossResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of ProfitLoss objects
         */
        [HttpGet("index")]
        public async Task<ActionResult<List<ProfitLossResponse>>> Index()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single ProfitLoss object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<ProfitLossResponse>> View(long id)
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
        public async Task<ActionResult<ProfitLossResponse>> Create([FromBody] ProfitLossRequest request)
        {
            try { return await _service.Create(request); } catch (Microsoft.EntityFrameworkCore.DbUpdateException dbEx) { var inner = dbEx.InnerException?.Message ?? ""; if (inner.Contains("foreign key constraint fails")) return BadRequest(new { message = "Invalid ID provided. The related record (e.g. Party or Employee) does not exist." }); return StatusCode(500, new { message = dbEx.Message }); } catch (System.Exception ex) { return StatusCode(500, new { message = ex.Message }); }
        }

        /**
         * Update existing record
         *
         * @param id Record identifier
         * @param request Updated data
         * @return Updated record response
         */
        [HttpPut("update/{id}")]
        public async Task<ActionResult<ProfitLossResponse>> Update(long id, [FromBody] ProfitLossRequest request)
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









