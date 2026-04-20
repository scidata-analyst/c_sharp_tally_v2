using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.RemoteAccessSecurity;
using TALLY_APP.DTOs.Request.RemoteAccessSecurity;
using TALLY_APP.DTOs.Response.RemoteAccessSecurity;

namespace TALLY_APP.Controllers.RemoteAccessSecurity
{
    /**
     * Controller: SecuritySettings
     *
     * Description:
     * Handles all CRUD operations for SecuritySettings module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("SecuritySettings")]
    public class SecuritySettingsController : Controller
    {
        private readonly ISecuritySettingsService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public SecuritySettingsController(ISecuritySettingsService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult Index() => View("~/Views/RemoteAccessSecurity/encryption.cshtml");

        /**
         * Get all records
         *
         * @return List of SecuritySettings objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<SecuritySettingsResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of SecuritySettings objects
         */
        [HttpGet("api/index")]
        public async Task<ActionResult<List<SecuritySettingsResponse>>> ApiIndex()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single SecuritySettings object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<SecuritySettingsResponse>> View(long id)
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
        public async Task<ActionResult<SecuritySettingsResponse>> Create([FromBody] SecuritySettingsRequest request)
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
        public async Task<ActionResult<SecuritySettingsResponse>> Update(long id, [FromBody] SecuritySettingsRequest request)
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

