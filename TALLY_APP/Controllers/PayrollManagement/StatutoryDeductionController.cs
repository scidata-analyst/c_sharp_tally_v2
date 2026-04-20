using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.PayrollManagement;
using TALLY_APP.DTOs.Request.PayrollManagement;
using TALLY_APP.DTOs.Response.PayrollManagement;

namespace TALLY_APP.Controllers.PayrollManagement
{
    /**
     * Controller: StatutoryDeduction
     *
     * Description:
     * Handles all CRUD operations for StatutoryDeduction module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("StatutoryDeduction")]
    public class StatutoryDeductionController : Controller
    {
        private readonly IStatutoryDeductionService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public StatutoryDeductionController(IStatutoryDeductionService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult Index() => View("~/Views/PayrollManagement/deductions.cshtml");

        /**
         * Get all records
         *
         * @return List of StatutoryDeduction objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<StatutoryDeductionResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of StatutoryDeduction objects
         */
        [HttpGet("api/index")]
        public async Task<ActionResult<List<StatutoryDeductionResponse>>> ApiIndex()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single StatutoryDeduction object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<StatutoryDeductionResponse>> View(long id)
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
        public async Task<ActionResult<StatutoryDeductionResponse>> Create([FromBody] StatutoryDeductionRequest request)
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
        public async Task<ActionResult<StatutoryDeductionResponse>> Update(long id, [FromBody] StatutoryDeductionRequest request)
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

