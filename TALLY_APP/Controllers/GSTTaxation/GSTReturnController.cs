using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using GSTTaxation.Services;
using GSTTaxation.DTOs.Request;
using GSTTaxation.DTOs.Response;

namespace TALLY_APP.Controllers.GSTTaxation
{
    /**
     * Controller: GSTReturn
     *
     * Description:
     * Handles all CRUD operations for GSTReturn module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("GSTReturn")]
    public class GSTReturnController : Controller
    {
        private readonly IGSTReturnService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public GSTReturnController(IGSTReturnService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult Index() => View("~/Views/GSTTaxation/tax-reports.cshtml");

        /**
         * Get all records
         *
         * @return List of GSTReturn objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<GSTReturnResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of GSTReturn objects
         */
        [HttpGet("api/index")]
        public async Task<ActionResult<List<GSTReturnResponse>>> ApiIndex()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single GSTReturn object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<GSTReturnResponse>> View(long id)
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
        public async Task<ActionResult<GSTReturnResponse>> Create([FromBody] GSTReturnRequest request)
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
        public async Task<ActionResult<GSTReturnResponse>> Update(long id, [FromBody] GSTReturnRequest request)
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
