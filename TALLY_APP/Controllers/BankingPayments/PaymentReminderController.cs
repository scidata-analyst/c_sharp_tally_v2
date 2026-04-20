using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.BankingPayments;
using TALLY_APP.DTOs.Request.BankingPayments;
using TALLY_APP.DTOs.Response.BankingPayments;

namespace TALLY_APP.Controllers.BankingPayments
{
    /**
     * Controller: PaymentReminder
     *
     * Description:
     * Handles all CRUD operations for PaymentReminder module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("PaymentReminder")]
    public class PaymentReminderController : Controller
    {
        private readonly IPaymentReminderService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public PaymentReminderController(IPaymentReminderService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult Index() => View("~/Views/BankingPayments/reminders.cshtml");

        /**
         * Get all records
         *
         * @return List of PaymentReminder objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<PaymentReminderResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of PaymentReminder objects
         */
        [HttpGet("api/index")]
        public async Task<ActionResult<List<PaymentReminderResponse>>> ApiIndex()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single PaymentReminder object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<PaymentReminderResponse>> View(long id)
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
        public async Task<ActionResult<PaymentReminderResponse>> Create([FromBody] PaymentReminderRequest request)
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
        public async Task<ActionResult<PaymentReminderResponse>> Update(long id, [FromBody] PaymentReminderRequest request)
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

