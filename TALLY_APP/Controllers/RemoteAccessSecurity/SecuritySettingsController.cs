using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.RemoteAccessSecurity;
using TALLY_APP.DTOs.Request.RemoteAccessSecurity;
using TALLY_APP.DTOs.Response.RemoteAccessSecurity;

namespace TALLY_APP.Controllers.RemoteAccessSecurity
{
    
    
    
    [Route("SecuritySettings")]
    [ApiController]
    public class SecuritySettingsController : Controller
    {
        [HttpGet("")]
        public IActionResult Index() => View("~/Views/RemoteAccessSecurity/encryption.cshtml");

        private readonly ISecuritySettingsService _service;

        public SecuritySettingsController(ISecuritySettingsService service)
        {
            _service = service;
        }

        [HttpGet("api/index")]
        public async Task<ActionResult<PaginatedSecuritySettingsResponse>> ApiIndex(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string search = "",
            [FromQuery] string sortColumn = "Id",
            [FromQuery] string sortDirection = "desc")
        {
            return await _service.Index(page, pageSize, search, sortColumn, sortDirection);
        }

        [HttpGet("view/{id}")]
        public async Task<ActionResult<SecuritySettingsResponse>> View(long id)
        {
            var result = await _service.View(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpPut("update/{id}")]
        public async Task<ActionResult<SecuritySettingsResponse>> Update(long id, [FromBody] SecuritySettingsRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errors = GetModelStateErrors() });

            try { var result = await _service.Update(id, request); return Ok(result); } catch (Microsoft.EntityFrameworkCore.DbUpdateException dbEx) { var inner = dbEx.InnerException?.Message ?? ""; if (inner.Contains("foreign key constraint fails")) return BadRequest(new { message = "Invalid ID provided. The related record (e.g. Party or Employee) does not exist." }); return StatusCode(500, new { message = dbEx.Message }); } catch (System.Exception ex) { return StatusCode(500, new { message = ex.Message }); }
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













