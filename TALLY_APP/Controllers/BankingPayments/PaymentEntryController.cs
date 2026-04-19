using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using BankingPayments.Services;
using BankingPayments.DTOs.Request;
using BankingPayments.DTOs.Response;

namespace TALLY_APP.Controllers.BankingPayments
{
    /**
     * Controller: PaymentEntry
     *
     * Description:
     * Handles all CRUD operations for PaymentEntry module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("api/BankingPayments/PaymentEntry")]
    public class PaymentEntryController : ControllerBase
    {
        private readonly IPaymentEntryService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public PaymentEntryController(IPaymentEntryService service)
        {
            _service = service;
        }

        /**
         * Get all records
         *
         * @return List of PaymentEntry objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<PaymentEntryResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of PaymentEntry objects
         */
        [HttpGet("index")]
        public async Task<ActionResult<List<PaymentEntryResponse>>> Index()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single PaymentEntry object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<PaymentEntryResponse>> View(long id)
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
        public async Task<ActionResult<PaymentEntryResponse>> Create([FromBody] PaymentEntryRequest request)
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
        public async Task<ActionResult<PaymentEntryResponse>> Update(long id, [FromBody] PaymentEntryRequest request)
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
