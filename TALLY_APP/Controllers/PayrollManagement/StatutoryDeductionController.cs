using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.PayrollManagement;
using TALLY_APP.DTOs.Request.PayrollManagement;
using TALLY_APP.DTOs.Response.PayrollManagement;

namespace TALLY_APP.Controllers.PayrollManagement
{
    
    
    
    [Route("StatutoryDeduction")]
    [ApiController]
    public class StatutoryDeductionController : Controller
    {
        [HttpGet("")]
        public IActionResult Index() => View("~/Views/PayrollManagement/deductions.cshtml");

        private readonly IStatutoryDeductionService _service;

        public StatutoryDeductionController(IStatutoryDeductionService service)
        {
            _service = service;
        }

        [HttpGet("all")]
        public async Task<ActionResult<List<StatutoryDeductionResponse>>> GetAll()
        {
            return await _service.All();
        }

        [HttpGet("api/index")]
        public async Task<ActionResult<PaginatedStatutoryDeductionResponse>> ApiIndex(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string search = "",
            [FromQuery] string sortColumn = "Id",
            [FromQuery] string sortDirection = "asc")
        {
            return await _service.Index(page, pageSize, search, sortColumn, sortDirection);
        }

        [HttpGet("view/{id}")]
        public async Task<ActionResult<StatutoryDeductionResponse>> View(long id)
        {
            var result = await _service.View(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpPost("create")]
        public async Task<ActionResult<StatutoryDeductionResponse>> Create([FromBody] StatutoryDeductionRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errors = GetModelStateErrors() });

            var result = await _service.Create(request);
            return Ok(result);
        }

        [HttpPut("update/{id}")]
        public async Task<ActionResult<StatutoryDeductionResponse>> Update(long id, [FromBody] StatutoryDeductionRequest request)
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











