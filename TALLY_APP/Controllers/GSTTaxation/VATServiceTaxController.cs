using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.GSTTaxation;
using TALLY_APP.DTOs.Request.GSTTaxation;
using TALLY_APP.DTOs.Response.GSTTaxation;

namespace TALLY_APP.Controllers.GSTTaxation
{
    /**
     * Controller: VATServiceTax
     *
     * Description:
     * Handles all CRUD operations for VATServiceTax module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("VATServiceTax")]
    public class VATServiceTaxController : Controller
    {
        private readonly IVATServiceTaxService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public VATServiceTaxController(IVATServiceTaxService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult Index() => View("~/Views/GSTTaxation/vat-service.cshtml");

        /**
         * Get all records
         *
         * @return List of VATServiceTax objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<VATServiceTaxResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of VATServiceTax objects
         */
        [HttpGet("api/index")]
        public async Task<ActionResult<List<VATServiceTaxResponse>>> ApiIndex()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single VATServiceTax object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<VATServiceTaxResponse>> View(long id)
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
        public async Task<ActionResult<VATServiceTaxResponse>> Create([FromBody] VATServiceTaxRequest request)
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
        public async Task<ActionResult<VATServiceTaxResponse>> Update(long id, [FromBody] VATServiceTaxRequest request)
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

