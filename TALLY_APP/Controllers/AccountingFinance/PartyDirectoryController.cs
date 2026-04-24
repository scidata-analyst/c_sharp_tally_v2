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
     * Controller: PartyDirectory
     *
     * Description:
     * Handles all CRUD operations for PartyDirectory module.
     * Follows RESTful API standards with Clean Architecture.
     */
    
    
    
    [Route("PartyDirectory")]
    [ApiController]
    public class PartyDirectoryController : Controller
    {
        [HttpGet("")]
        public IActionResult Index() => View("~/Views/AccountingFinance/payable.cshtml");

        private readonly IPartyDirectoryService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public PartyDirectoryController(IPartyDirectoryService service)
        {
            _service = service;
        }

        /**
         * Get all records
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<PartyDirectoryResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list with server-side search, sort, pagination
         */
        [HttpGet("api/index")]
        public async Task<ActionResult<PaginatedPartyResponse>> ApiIndex(
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
        public async Task<ActionResult<PartyDirectoryResponse>> View(long id)
        {
            var result = await _service.View(id);
            if (result == null) return NotFound();
            return result;
        }

        /**
         * Create new record
         */
        [HttpPost("create")]
        public async Task<ActionResult<PartyDirectoryResponse>> Create([FromBody] PartyDirectoryRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errors = GetModelStateErrors() });

            try { var result = await _service.Create(request); return Ok(result); } catch (Microsoft.EntityFrameworkCore.DbUpdateException dbEx) { var inner = dbEx.InnerException?.Message ?? ""; if (inner.Contains("foreign key constraint fails")) return BadRequest(new { message = "Invalid ID provided. The related record (e.g. Party or Employee) does not exist." }); return StatusCode(500, new { message = dbEx.Message }); } catch (System.Exception ex) { return StatusCode(500, new { message = ex.Message }); }
        }

        /**
         * Update existing record
         */
        [HttpPut("update/{id}")]
        public async Task<ActionResult<PartyDirectoryResponse>> Update(long id, [FromBody] PartyDirectoryRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errors = GetModelStateErrors() });

            try { var result = await _service.Update(id, request); return Ok(result); } catch (Microsoft.EntityFrameworkCore.DbUpdateException dbEx) { var inner = dbEx.InnerException?.Message ?? ""; if (inner.Contains("foreign key constraint fails")) return BadRequest(new { message = "Invalid ID provided. The related record (e.g. Party or Employee) does not exist." }); return StatusCode(500, new { message = dbEx.Message }); } catch (System.Exception ex) { return StatusCode(500, new { message = ex.Message }); }
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













