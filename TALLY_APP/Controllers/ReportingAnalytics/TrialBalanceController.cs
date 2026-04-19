using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReportingAnalytics.Services;
using ReportingAnalytics.DTOs.Request;
using ReportingAnalytics.DTOs.Response;

namespace TALLY_APP.Controllers.ReportingAnalytics
{
    /**
     * Controller: TrialBalance
     *
     * Description:
     * Handles all CRUD operations for TrialBalance module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("TrialBalance")]
    public class TrialBalanceController : Controller
    {
        private readonly ITrialBalanceService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public TrialBalanceController(ITrialBalanceService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult Index() => View("~/Views/ReportingAnalytics/trial-balance.cshtml");

        /**
         * Get all records
         *
         * @return List of TrialBalance objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<TrialBalanceResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of TrialBalance objects
         */
        [HttpGet("api/index")]
        public async Task<ActionResult<List<TrialBalanceResponse>>> ApiIndex()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single TrialBalance object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<TrialBalanceResponse>> View(long id)
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
        public async Task<ActionResult<TrialBalanceResponse>> Create([FromBody] TrialBalanceRequest request)
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
        public async Task<ActionResult<TrialBalanceResponse>> Update(long id, [FromBody] TrialBalanceRequest request)
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
