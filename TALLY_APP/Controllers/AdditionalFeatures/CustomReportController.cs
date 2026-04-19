using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdditionalFeatures.Services;
using AdditionalFeatures.DTOs.Request;
using AdditionalFeatures.DTOs.Response;

namespace TALLY_APP.Controllers.AdditionalFeatures
{
    /**
     * Controller: CustomReport
     *
     * Description:
     * Handles all CRUD operations for CustomReport module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("CustomReport")]
    public class CustomReportController : Controller
    {
        private readonly ICustomReportService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public CustomReportController(ICustomReportService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult Index() => View("~/Views/AdditionalFeatures/custom-reports.cshtml");

        /**
         * Get all records
         *
         * @return List of CustomReport objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<CustomReportResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of CustomReport objects
         */
        [HttpGet("api/index")]
        public async Task<ActionResult<List<CustomReportResponse>>> ApiIndex()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single CustomReport object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<CustomReportResponse>> View(long id)
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
        public async Task<ActionResult<CustomReportResponse>> Create([FromBody] CustomReportRequest request)
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
        public async Task<ActionResult<CustomReportResponse>> Update(long id, [FromBody] CustomReportRequest request)
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
