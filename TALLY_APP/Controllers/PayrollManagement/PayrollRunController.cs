using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using PayrollManagement.Services;
using PayrollManagement.DTOs.Request;
using PayrollManagement.DTOs.Response;

namespace POS_APP.Controllers.PayrollManagement
{
    /**
     * Controller: PayrollRun
     *
     * Description:
     * Handles all CRUD operations for PayrollRun module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("api/PayrollManagement/PayrollRun")]
    public class PayrollRunController : ControllerBase
    {
        private readonly IPayrollRunService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public PayrollRunController(IPayrollRunService service)
        {
            _service = service;
        }

        /**
         * Get all records
         *
         * @return List of PayrollRun objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<PayrollRunResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of PayrollRun objects
         */
        [HttpGet("index")]
        public async Task<ActionResult<List<PayrollRunResponse>>> Index()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single PayrollRun object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<PayrollRunResponse>> View(long id)
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
        public async Task<ActionResult<PayrollRunResponse>> Create([FromBody] PayrollRunRequest request)
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
        public async Task<ActionResult<PayrollRunResponse>> Update(long id, [FromBody] PayrollRunRequest request)
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
