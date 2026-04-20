using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.GSTTaxation;
using TALLY_APP.DTOs.Request.GSTTaxation;
using TALLY_APP.DTOs.Response.GSTTaxation;

namespace TALLY_APP.Controllers.GSTTaxation
{
    /**
     * Controller: GSTEntry
     *
     * Description:
     * Handles all CRUD operations for GSTEntry module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("GSTEntry")]
    public class GSTEntryController : Controller
    {
        private readonly IGSTEntryService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public GSTEntryController(IGSTEntryService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult Index() => View("~/Views/GSTTaxation/gst-calc.cshtml");

        /**
         * Get all records
         *
         * @return List of GSTEntry objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<GSTEntryResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of GSTEntry objects
         */
        [HttpGet("api/index")]
        public async Task<ActionResult<List<GSTEntryResponse>>> ApiIndex()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single GSTEntry object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<GSTEntryResponse>> View(long id)
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
        public async Task<ActionResult<GSTEntryResponse>> Create([FromBody] GSTEntryRequest request)
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
        public async Task<ActionResult<GSTEntryResponse>> Update(long id, [FromBody] GSTEntryRequest request)
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

