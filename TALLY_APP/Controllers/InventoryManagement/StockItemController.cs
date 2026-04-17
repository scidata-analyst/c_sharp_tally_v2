using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using InventoryManagement.Services;
using InventoryManagement.DTOs.Request;
using InventoryManagement.DTOs.Response;

namespace TALLY_APP.Controllers.InventoryManagement
{
    /**
     * Controller: StockItem
     *
     * Description:
     * Handles all CRUD operations for StockItem module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("api/InventoryManagement/StockItem")]
    public class StockItemController : ControllerBase
    {
        private readonly IStockItemService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public StockItemController(IStockItemService service)
        {
            _service = service;
        }

        /**
         * Get all records
         *
         * @return List of StockItem objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<StockItemResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of StockItem objects
         */
        [HttpGet("index")]
        public async Task<ActionResult<List<StockItemResponse>>> Index()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single StockItem object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<StockItemResponse>> View(long id)
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
        public async Task<ActionResult<StockItemResponse>> Create([FromBody] StockItemRequest request)
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
        public async Task<ActionResult<StockItemResponse>> Update(long id, [FromBody] StockItemRequest request)
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
