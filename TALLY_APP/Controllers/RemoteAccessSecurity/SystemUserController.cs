using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.RemoteAccessSecurity;
using TALLY_APP.DTOs.Request.RemoteAccessSecurity;
using TALLY_APP.DTOs.Response.RemoteAccessSecurity;

namespace TALLY_APP.Controllers.RemoteAccessSecurity
{
    
    
    
    [Route("SystemUser")]
    [ApiController]
    public class SystemUserController : Controller
    {
        [HttpGet("")]
        public IActionResult Index() => View("~/Views/RemoteAccessSecurity/user-access.cshtml");

        private readonly ISystemUserService _service;

        public SystemUserController(ISystemUserService service)
        {
            _service = service;
        }

        [HttpGet("api/index")]
        public async Task<ActionResult<PaginatedSystemUserResponse>> ApiIndex(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string search = "",
            [FromQuery] string sortColumn = "Id",
            [FromQuery] string sortDirection = "asc")
        {
            return await _service.Index(page, pageSize, search, sortColumn, sortDirection);
        }

        [HttpPost("create")]
        public async Task<ActionResult<SystemUserResponse>> Create([FromBody] SystemUserRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errors = GetModelStateErrors() });

            var result = await _service.Create(request);
            return Ok(result);
        }

        [HttpPut("update/{id}")]
        public async Task<ActionResult<SystemUserResponse>> Update(long id, [FromBody] SystemUserRequest request)
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











