using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.BankingPayments;
using TALLY_APP.DTOs.Request.BankingPayments;
using TALLY_APP.DTOs.Response.BankingPayments;

namespace TALLY_APP.Controllers.BankingPayments
{
    /**
     * Controller: BankIntegration
     *
     * Description:
     * Handles all CRUD operations for BankIntegration module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("BankIntegration")]
    public class BankIntegrationController : Controller
    {
        private readonly IBankIntegrationService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public BankIntegrationController(IBankIntegrationService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult Index() => View("~/Views/BankingPayments/banking-integration.cshtml");

        /**
         * Get all records
         *
         * @return List of BankIntegration objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<BankIntegrationResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of BankIntegration objects
         */
        [HttpGet("api/index")]
        public async Task<ActionResult<List<BankIntegrationResponse>>> ApiIndex()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single BankIntegration object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<BankIntegrationResponse>> View(long id)
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
        public async Task<ActionResult<BankIntegrationResponse>> Create([FromBody] BankIntegrationRequest request)
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
        public async Task<ActionResult<BankIntegrationResponse>> Update(long id, [FromBody] BankIntegrationRequest request)
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

