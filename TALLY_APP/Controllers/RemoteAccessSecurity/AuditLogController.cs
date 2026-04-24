using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.RemoteAccessSecurity;
using TALLY_APP.DTOs.Request.RemoteAccessSecurity;
using TALLY_APP.DTOs.Response.RemoteAccessSecurity;

namespace TALLY_APP.Controllers.RemoteAccessSecurity
{
    
    
    
    [Route("AuditLog")]
    [ApiController]
    public class AuditLogController : Controller
    {
        [HttpGet("")]
        public IActionResult Index() => View("~/Views/RemoteAccessSecurity/audit.cshtml");

        private readonly IAuditLogService _service;

        public AuditLogController(IAuditLogService service)
        {
            _service = service;
        }

        [HttpGet("api/index")]
        public async Task<ActionResult<PaginatedAuditLogResponse>> ApiIndex(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string search = "",
            [FromQuery] string sortColumn = "Id",
            [FromQuery] string sortDirection = "desc")
        {
            return await _service.Index(page, pageSize, search, sortColumn, sortDirection);
        }

        [HttpPost("create")]
        public async Task<ActionResult<AuditLogResponse>> Create([FromBody] AuditLogRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errors = GetModelStateErrors() });

            try { var result = await _service.Create(request); return Ok(result); } catch (Microsoft.EntityFrameworkCore.DbUpdateException dbEx) { var inner = dbEx.InnerException?.Message ?? ""; if (inner.Contains("foreign key constraint fails")) return BadRequest(new { message = "Invalid ID provided. The related record (e.g. Party or Employee) does not exist." }); return StatusCode(500, new { message = dbEx.Message }); } catch (System.Exception ex) { return StatusCode(500, new { message = ex.Message }); }
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













