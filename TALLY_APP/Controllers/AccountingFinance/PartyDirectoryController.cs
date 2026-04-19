using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AccountingFinance.Services;
using AccountingFinance.DTOs.Request;
using AccountingFinance.DTOs.Response;

namespace TALLY_APP.Controllers.AccountingFinance
{
    /**
     * Controller: PartyDirectory
     *
     * Description:
     * Handles all CRUD operations for PartyDirectory module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("api/AccountingFinance/PartyDirectory")]
    public class PartyDirectoryController : ControllerBase
    {
        private readonly IPartyDirectoryService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public PartyDirectoryController(IPartyDirectoryService service)
        {
            _service = service;
        }

        /**
         * Get all records
         *
         * @return List of PartyDirectory objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<PartyDirectoryResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of PartyDirectory objects
         */
        [HttpGet("index")]
        public async Task<ActionResult<List<PartyDirectoryResponse>>> Index()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single PartyDirectory object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<PartyDirectoryResponse>> View(long id)
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
        public async Task<ActionResult<PartyDirectoryResponse>> Create([FromBody] PartyDirectoryRequest request)
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
        public async Task<ActionResult<PartyDirectoryResponse>> Update(long id, [FromBody] PartyDirectoryRequest request)
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
