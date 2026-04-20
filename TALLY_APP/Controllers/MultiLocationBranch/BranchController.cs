using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.MultiLocationBranch;
using TALLY_APP.DTOs.Request.MultiLocationBranch;
using TALLY_APP.DTOs.Response.MultiLocationBranch;

namespace TALLY_APP.Controllers.MultiLocationBranch
{
    /**
     * Controller: Branch
     *
     * Description:
     * Handles all CRUD operations for Branch module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("Branch")]
    public class BranchController : Controller
    {
        private readonly IBranchService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public BranchController(IBranchService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult Index() => View("~/Views/MultiLocationBranch/branches.cshtml");

        /**
         * Get all records
         *
         * @return List of Branch objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<BranchResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of Branch objects
         */
        [HttpGet("api/index")]
        public async Task<ActionResult<List<BranchResponse>>> ApiIndex()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single Branch object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<BranchResponse>> View(long id)
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
        public async Task<ActionResult<BranchResponse>> Create([FromBody] BranchRequest request)
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
        public async Task<ActionResult<BranchResponse>> Update(long id, [FromBody] BranchRequest request)
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

