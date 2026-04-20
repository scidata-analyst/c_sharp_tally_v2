using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.MultiLocationBranch;
using TALLY_APP.DTOs.Request.MultiLocationBranch;
using TALLY_APP.DTOs.Response.MultiLocationBranch;

namespace TALLY_APP.Controllers.MultiLocationBranch
{
    /**
     * Controller: BranchConsolidation
     *
     * Description:
     * Handles all CRUD operations for BranchConsolidation module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("BranchConsolidation")]
    public class BranchConsolidationController : Controller
    {
        private readonly IBranchConsolidationService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public BranchConsolidationController(IBranchConsolidationService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult Index() => View("~/Views/MultiLocationBranch/consolidation.cshtml");

        /**
         * Get all records
         *
         * @return List of BranchConsolidation objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<BranchConsolidationResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of BranchConsolidation objects
         */
        [HttpGet("api/index")]
        public async Task<ActionResult<List<BranchConsolidationResponse>>> ApiIndex()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single BranchConsolidation object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<BranchConsolidationResponse>> View(long id)
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
        public async Task<ActionResult<BranchConsolidationResponse>> Create([FromBody] BranchConsolidationRequest request)
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
        public async Task<ActionResult<BranchConsolidationResponse>> Update(long id, [FromBody] BranchConsolidationRequest request)
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

