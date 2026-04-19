using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AccountingFinance.Services;
using AccountingFinance.DTOs.Request;
using AccountingFinance.DTOs.Response;

namespace TALLY_APP.Controllers.AccountingFinance
{
    /**
     * Controller: VoucherEntry
     *
     * Description:
     * Handles all CRUD operations for VoucherEntry module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("api/AccountingFinance/VoucherEntry")]
    public class VoucherEntryController : ControllerBase
    {
        private readonly IVoucherEntryService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public VoucherEntryController(IVoucherEntryService service)
        {
            _service = service;
        }

        /**
         * Get all records
         *
         * @return List of VoucherEntry objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<VoucherEntryResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of VoucherEntry objects
         */
        [HttpGet("index")]
        public async Task<ActionResult<List<VoucherEntryResponse>>> Index()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single VoucherEntry object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<VoucherEntryResponse>> View(long id)
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
        public async Task<ActionResult<VoucherEntryResponse>> Create([FromBody] VoucherEntryRequest request)
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
        public async Task<ActionResult<VoucherEntryResponse>> Update(long id, [FromBody] VoucherEntryRequest request)
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
