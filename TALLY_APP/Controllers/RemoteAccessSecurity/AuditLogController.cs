using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using RemoteAccessSecurity.Services;
using RemoteAccessSecurity.DTOs.Request;
using RemoteAccessSecurity.DTOs.Response;

namespace TALLY_APP.Controllers.RemoteAccessSecurity
{
    /**
     * Controller: AuditLog
     *
     * Description:
     * Handles all CRUD operations for AuditLog module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("api/RemoteAccessSecurity/AuditLog")]
    public class AuditLogController : ControllerBase
    {
        private readonly IAuditLogService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public AuditLogController(IAuditLogService service)
        {
            _service = service;
        }

        /**
         * Get all records
         *
         * @return List of AuditLog objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<AuditLogResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of AuditLog objects
         */
        [HttpGet("index")]
        public async Task<ActionResult<List<AuditLogResponse>>> Index()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single AuditLog object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<AuditLogResponse>> View(long id)
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
        public async Task<ActionResult<AuditLogResponse>> Create([FromBody] AuditLogRequest request)
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
        public async Task<ActionResult<AuditLogResponse>> Update(long id, [FromBody] AuditLogRequest request)
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
