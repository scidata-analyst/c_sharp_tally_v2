using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dashboard.Services;
using Dashboard.DTOs.Request;
using Dashboard.DTOs.Response;

namespace TALLY_APP.Controllers.Dashboard
{
    /**
     * Controller: DashboardWidget
     *
     * Description:
     * Handles all CRUD operations for DashboardWidget module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("api/Dashboard/DashboardWidget")]
    public class DashboardWidgetController : ControllerBase
    {
        private readonly IDashboardWidgetService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public DashboardWidgetController(IDashboardWidgetService service)
        {
            _service = service;
        }

        /**
         * Get all records
         *
         * @return List of DashboardWidget objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<DashboardWidgetResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of DashboardWidget objects
         */
        [HttpGet("index")]
        public async Task<ActionResult<List<DashboardWidgetResponse>>> Index()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single DashboardWidget object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<DashboardWidgetResponse>> View(long id)
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
        public async Task<ActionResult<DashboardWidgetResponse>> Create([FromBody] DashboardWidgetRequest request)
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
        public async Task<ActionResult<DashboardWidgetResponse>> Update(long id, [FromBody] DashboardWidgetRequest request)
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
