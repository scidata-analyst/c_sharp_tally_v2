using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using GSTTaxation.Services;
using GSTTaxation.DTOs.Request;
using GSTTaxation.DTOs.Response;

namespace POS_APP.Controllers.GSTTaxation
{
    /**
     * Controller: TDSTCSEntry
     *
     * Description:
     * Handles all CRUD operations for TDSTCSEntry module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("api/GSTTaxation/TDSTCSEntry")]
    public class TDSTCSEntryController : ControllerBase
    {
        private readonly ITDSTCSEntryService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public TDSTCSEntryController(ITDSTCSEntryService service)
        {
            _service = service;
        }

        /**
         * Get all records
         *
         * @return List of TDSTCSEntry objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<TDSTCSEntryResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of TDSTCSEntry objects
         */
        [HttpGet("index")]
        public async Task<ActionResult<List<TDSTCSEntryResponse>>> Index()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single TDSTCSEntry object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<TDSTCSEntryResponse>> View(long id)
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
        public async Task<ActionResult<TDSTCSEntryResponse>> Create([FromBody] TDSTCSEntryRequest request)
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
        public async Task<ActionResult<TDSTCSEntryResponse>> Update(long id, [FromBody] TDSTCSEntryRequest request)
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
