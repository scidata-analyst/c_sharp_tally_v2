using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AccountingFinance.Services;
using AccountingFinance.DTOs.Request;
using AccountingFinance.DTOs.Response;

namespace TALLY_APP.Controllers.AccountingFinance
{
    /**
     * Controller: CurrencyExchange
     *
     * Description:
     * Handles all CRUD operations for CurrencyExchange module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("api/AccountingFinance/CurrencyExchange")]
    public class CurrencyExchangeController : ControllerBase
    {
        private readonly ICurrencyExchangeService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public CurrencyExchangeController(ICurrencyExchangeService service)
        {
            _service = service;
        }

        /**
         * Get all records
         *
         * @return List of CurrencyExchange objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<CurrencyExchangeResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of CurrencyExchange objects
         */
        [HttpGet("index")]
        public async Task<ActionResult<List<CurrencyExchangeResponse>>> Index()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single CurrencyExchange object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<CurrencyExchangeResponse>> View(long id)
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
        public async Task<ActionResult<CurrencyExchangeResponse>> Create([FromBody] CurrencyExchangeRequest request)
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
        public async Task<ActionResult<CurrencyExchangeResponse>> Update(long id, [FromBody] CurrencyExchangeRequest request)
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
