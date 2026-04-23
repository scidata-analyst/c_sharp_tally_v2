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
     * Controller: CurrencyExchange
     *
     * Description:
     * Handles all CRUD operations for CurrencyExchange module.
     */
    [ApiController]
    [Route("CurrencyExchange")]
    public class CurrencyExchangeController : Controller
    {
        private readonly ICurrencyExchangeService _service;

        public CurrencyExchangeController(ICurrencyExchangeService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult Index() => View("~/Views/AccountingFinance/multicurrency.cshtml");

        /**
         * Get all records
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<CurrencyExchangeResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list with server-side search, sort, pagination
         */
        [HttpGet("api/index")]
        public async Task<ActionResult<PaginatedCurrencyResponse>> ApiIndex(
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
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<CurrencyExchangeResponse>> View(long id)
        {
            var result = await _service.View(id);
            if (result == null) return NotFound();
            return result;
        }

        /**
         * Create new record
         */
        [HttpPost("create")]
        public async Task<ActionResult<CurrencyExchangeResponse>> Create([FromBody] CurrencyExchangeRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errors = GetModelStateErrors() });

            var result = await _service.Create(request);
            return Ok(result);
        }

        /**
         * Update existing record
         */
        [HttpPut("update/{id}")]
        public async Task<ActionResult<CurrencyExchangeResponse>> Update(long id, [FromBody] CurrencyExchangeRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errors = GetModelStateErrors() });

            var result = await _service.Update(id, request);
            return Ok(result);
        }

        /**
         * Delete record
         */
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _service.Delete(id);
            return Ok(new { message = "Deleted successfully" });
        }

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
