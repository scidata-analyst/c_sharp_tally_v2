using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.AdditionalFeatures;
using TALLY_APP.DTOs.Request.AdditionalFeatures;
using TALLY_APP.DTOs.Response.AdditionalFeatures;

namespace TALLY_APP.Controllers.AdditionalFeatures
{
     
    
    [Route("Budget")]
    [ApiController]
    public class BudgetController : Controller
    {
        [HttpGet("")]
        public IActionResult Index() => View("~/Views/AdditionalFeatures/budget.cshtml");

        private readonly IBudgetService _service;
        public BudgetController(IBudgetService service) => _service = service;

        [HttpGet("api/index")]
        public async Task<ActionResult<PaginatedBudgetResponse>> ApiIndex([FromQuery] int page = 1, [FromQuery] int pageSize = 10, [FromQuery] string search = "", [FromQuery] string sortColumn = "Id", [FromQuery] string sortDirection = "asc")
            => await _service.Index(page, pageSize, search, sortColumn, sortDirection);

        [HttpPost("create")]
        public async Task<ActionResult<BudgetResponse>> Create([FromBody] BudgetRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(new { errors = GetModelStateErrors() });
            return Ok(await _service.Create(request));
        }

        [HttpPut("update/{id}")]
        public async Task<ActionResult<BudgetResponse>> Update(long id, [FromBody] BudgetRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(new { errors = GetModelStateErrors() });
            return Ok(await _service.Update(id, request));
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(long id) { await _service.Delete(id); return Ok(new { message = "Deleted" }); }

        private Dictionary<string, string[]> GetModelStateErrors() => ModelState.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray());
    }
}











