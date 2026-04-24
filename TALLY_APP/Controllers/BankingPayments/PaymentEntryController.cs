using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.BankingPayments;
using TALLY_APP.DTOs.Request.BankingPayments;
using TALLY_APP.DTOs.Response.BankingPayments;

namespace TALLY_APP.Controllers.BankingPayments
{
    
    
    
    [Route("PaymentEntry")]
    [ApiController]
    public class PaymentEntryController : Controller
    {
        [HttpGet("")]
        public IActionResult Index() => View("~/Views/BankingPayments/payment-processing.cshtml");

        private readonly IPaymentEntryService _service;

        public PaymentEntryController(IPaymentEntryService service)
        {
            _service = service;
        }

        [HttpGet("all")]
        public async Task<ActionResult<List<PaymentEntryResponse>>> GetAll()
        {
            return await _service.All();
        }

        [HttpGet("api/index")]
        public async Task<ActionResult<PaginatedPaymentEntryResponse>> ApiIndex(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string search = "",
            [FromQuery] string sortColumn = "Id",
            [FromQuery] string sortDirection = "asc")
        {
            return await _service.Index(page, pageSize, search, sortColumn, sortDirection);
        }

        [HttpGet("view/{id}")]
        public async Task<ActionResult<PaymentEntryResponse>> View(long id)
        {
            var result = await _service.View(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpPost("create")]
        public async Task<ActionResult<PaymentEntryResponse>> Create([FromBody] PaymentEntryRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errors = GetModelStateErrors() });

            var result = await _service.Create(request);
            return Ok(result);
        }

        [HttpPut("update/{id}")]
        public async Task<ActionResult<PaymentEntryResponse>> Update(long id, [FromBody] PaymentEntryRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errors = GetModelStateErrors() });

            var result = await _service.Update(id, request);
            return Ok(result);
        }

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











