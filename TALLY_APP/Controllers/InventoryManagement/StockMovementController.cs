using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.InventoryManagement;
using TALLY_APP.DTOs.Request.InventoryManagement;
using TALLY_APP.DTOs.Response.InventoryManagement;

namespace TALLY_APP.Controllers.InventoryManagement
{
    
    
    
    [Route("StockMovement")]
    [ApiController]
    public class StockMovementController : Controller
    {
        [HttpGet("")]
        public IActionResult Index() => View("~/Views/InventoryManagement/stock-movements.cshtml");

        private readonly IStockMovementService _service;

        public StockMovementController(IStockMovementService service)
        {
            _service = service;
        }

        [HttpGet("all")]
        public async Task<ActionResult<List<StockMovementResponse>>> GetAll()
        {
            return await _service.All();
        }

        [HttpGet("api/index")]
        public async Task<ActionResult<PaginatedStockMovementResponse>> ApiIndex(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string search = "",
            [FromQuery] string sortColumn = "Id",
            [FromQuery] string sortDirection = "asc")
        {
            return await _service.Index(page, pageSize, search, sortColumn, sortDirection);
        }

        [HttpGet("view/{id}")]
        public async Task<ActionResult<StockMovementResponse>> View(long id)
        {
            var result = await _service.View(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpPost("create")]
        public async Task<ActionResult<StockMovementResponse>> Create([FromBody] StockMovementRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errors = GetModelStateErrors() });

            try { var result = await _service.Create(request); return Ok(result); } catch (Microsoft.EntityFrameworkCore.DbUpdateException dbEx) { var inner = dbEx.InnerException?.Message ?? ""; if (inner.Contains("foreign key constraint fails")) return BadRequest(new { message = "Invalid ID provided. The related record (e.g. Party or Employee) does not exist." }); return StatusCode(500, new { message = dbEx.Message }); } catch (System.Exception ex) { return StatusCode(500, new { message = ex.Message }); }
        }

        [HttpPut("update/{id}")]
        public async Task<ActionResult<StockMovementResponse>> Update(long id, [FromBody] StockMovementRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { errors = GetModelStateErrors() });

            try { var result = await _service.Update(id, request); return Ok(result); } catch (Microsoft.EntityFrameworkCore.DbUpdateException dbEx) { var inner = dbEx.InnerException?.Message ?? ""; if (inner.Contains("foreign key constraint fails")) return BadRequest(new { message = "Invalid ID provided. The related record (e.g. Party or Employee) does not exist." }); return StatusCode(500, new { message = dbEx.Message }); } catch (System.Exception ex) { return StatusCode(500, new { message = ex.Message }); }
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













