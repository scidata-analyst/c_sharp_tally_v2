using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.AccountingFinance;
using TALLY_APP.DTOs.Request.AccountingFinance;
using TALLY_APP.DTOs.Response.AccountingFinance;

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
    [Route("LedgerAccount")]
    public class LedgerAccountController : Controller
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

        [HttpGet("")]
        public IActionResult Index() => View("~/Views/AccountingFinance/ledger.cshtml");

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
         * Get paginated list with server-side search, sort, pagination
         *
         * Query params:
         * - page: page number (default 1)
         * - pageSize: records per page (default 10)
         * - search: global search term
         * - sortColumn: column to sort by (default Id)
         * - sortDirection: asc or desc (default asc)
         *
         * @return PaginatedLedgerResponse
         */
        [HttpGet("api/index")]
        public async Task<ActionResult<PaginatedLedgerResponse>> ApiIndex(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string search = "",
            [FromQuery] string sortColumn = "Id",
            [FromQuery] string sortDirection = "asc")
        {
            return await _service.Index(page, pageSize, search, sortColumn, sortDirection);
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
            var result = await _service.View(id);
            if (result == null)
                return NotFound();
            return result;
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
            if (!ModelState.IsValid)
                return BadRequest(new { errors = GetModelStateErrors() });

            var result = await _service.Create(request);
            return Ok(result);
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
            if (!ModelState.IsValid)
                return BadRequest(new { errors = GetModelStateErrors() });

            var result = await _service.Update(id, request);
            return Ok(result);
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

        /**
         * Helper: Extract model state errors
         */
        private Dictionary<string, string[]> GetModelStateErrors()
        {
            var errors = new Dictionary<string, string[]>();
            foreach (var key in ModelState.Keys)
            {
                var state = ModelState[key];
                if (state.Errors.Count > 0)
                {
                    errors[key] = state.Errors.Select(e => e.ErrorMessage).ToArray();
                }
            }
            return errors;
        }
    }
}

