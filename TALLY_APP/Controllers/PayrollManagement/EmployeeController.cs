using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.PayrollManagement;
using TALLY_APP.DTOs.Request.PayrollManagement;
using TALLY_APP.DTOs.Response.PayrollManagement;

namespace TALLY_APP.Controllers.PayrollManagement
{
    /**
     * Controller: Employee
     *
     * Description:
     * Handles all CRUD operations for Employee module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("Employee")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult Index() => View("~/Views/PayrollManagement/employees.cshtml");

        /**
         * Get all records
         *
         * @return List of Employee objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<EmployeeResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of Employee objects
         */
        [HttpGet("api/index")]
        public async Task<ActionResult<List<EmployeeResponse>>> ApiIndex()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single Employee object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<EmployeeResponse>> View(long id)
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
        public async Task<ActionResult<EmployeeResponse>> Create([FromBody] EmployeeRequest request)
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
        public async Task<ActionResult<EmployeeResponse>> Update(long id, [FromBody] EmployeeRequest request)
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

