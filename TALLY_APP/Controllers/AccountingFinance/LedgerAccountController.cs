using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AccountingFinance.Services;
using AccountingFinance.DTOs.Request;
using AccountingFinance.DTOs.Response;

namespace TALLY_APP.Controllers.AccountingFinance
{
    /**
     * Controller: LedgerAccount
     *
     * Description:
     * Handles all CRUD operations for LedgerAccount module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("api/AccountingFinance/LedgerAccount")]
    public class LedgerAccountController : ControllerBase
    {
        private readonly ILedgerAccountService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public LedgerAccountController(ILedgerAccountService service)
        {
            _service = service;
        }

        /**
         * Get all records
         *
         * @return List of LedgerAccount objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<LedgerAccountResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of LedgerAccount objects
         */
        [HttpGet("index")]
        public async Task<ActionResult<List<LedgerAccountResponse>>> Index()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single LedgerAccount object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<LedgerAccountResponse>> View(long id)
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
        public async Task<ActionResult<LedgerAccountResponse>> Create([FromBody] LedgerAccountRequest request)
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
        public async Task<ActionResult<LedgerAccountResponse>> Update(long id, [FromBody] LedgerAccountRequest request)
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
