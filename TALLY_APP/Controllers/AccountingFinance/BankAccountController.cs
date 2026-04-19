using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AccountingFinance.Services;
using AccountingFinance.DTOs.Request;
using AccountingFinance.DTOs.Response;

namespace TALLY_APP.Controllers.AccountingFinance
{
    /**
     * Controller: BankAccount
     *
     * Description:
     * Handles all CRUD operations for BankAccount module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("BankAccount")]
    public class BankAccountController : Controller
    {
        private readonly IBankAccountService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public BankAccountController(IBankAccountService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult Index() => View("~/Views/AccountingFinance/cash-bank.cshtml");

        /**
         * Get all records
         *
         * @return List of BankAccount objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<BankAccountResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of BankAccount objects
         */
        [HttpGet("api/index")]
        public async Task<ActionResult<List<BankAccountResponse>>> ApiIndex()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single BankAccount object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<BankAccountResponse>> View(long id)
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
        public async Task<ActionResult<BankAccountResponse>> Create([FromBody] BankAccountRequest request)
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
        public async Task<ActionResult<BankAccountResponse>> Update(long id, [FromBody] BankAccountRequest request)
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
