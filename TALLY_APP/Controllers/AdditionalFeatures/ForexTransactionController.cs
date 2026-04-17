using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdditionalFeatures.Services;
using AdditionalFeatures.DTOs.Request;
using AdditionalFeatures.DTOs.Response;

namespace TALLY_APP.Controllers.AdditionalFeatures
{
    /**
     * Controller: ForexTransaction
     *
     * Description:
     * Handles all CRUD operations for ForexTransaction module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("api/AdditionalFeatures/ForexTransaction")]
    public class ForexTransactionController : ControllerBase
    {
        private readonly IForexTransactionService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public ForexTransactionController(IForexTransactionService service)
        {
            _service = service;
        }

        /**
         * Get all records
         *
         * @return List of ForexTransaction objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<ForexTransactionResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of ForexTransaction objects
         */
        [HttpGet("index")]
        public async Task<ActionResult<List<ForexTransactionResponse>>> Index()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single ForexTransaction object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<ForexTransactionResponse>> View(long id)
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
        public async Task<ActionResult<ForexTransactionResponse>> Create([FromBody] ForexTransactionRequest request)
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
        public async Task<ActionResult<ForexTransactionResponse>> Update(long id, [FromBody] ForexTransactionRequest request)
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
