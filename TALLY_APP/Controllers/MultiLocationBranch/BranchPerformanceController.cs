using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using MultiLocationBranch.Services;
using MultiLocationBranch.DTOs.Request;
using MultiLocationBranch.DTOs.Response;

namespace TALLY_APP.Controllers.MultiLocationBranch
{
    /**
     * Controller: BranchPerformance
     *
     * Description:
     * Handles all CRUD operations for BranchPerformance module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("api/MultiLocationBranch/BranchPerformance")]
    public class BranchPerformanceController : ControllerBase
    {
        private readonly IBranchPerformanceService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public BranchPerformanceController(IBranchPerformanceService service)
        {
            _service = service;
        }

        /**
         * Get all records
         *
         * @return List of BranchPerformance objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<BranchPerformanceResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of BranchPerformance objects
         */
        [HttpGet("index")]
        public async Task<ActionResult<List<BranchPerformanceResponse>>> Index()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single BranchPerformance object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<BranchPerformanceResponse>> View(long id)
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
        public async Task<ActionResult<BranchPerformanceResponse>> Create([FromBody] BranchPerformanceRequest request)
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
        public async Task<ActionResult<BranchPerformanceResponse>> Update(long id, [FromBody] BranchPerformanceRequest request)
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
