using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using InventoryManagement.Services;
using InventoryManagement.DTOs.Request;
using InventoryManagement.DTOs.Response;

namespace TALLY_APP.Controllers.InventoryManagement
{
    /**
     * Controller: BatchRegister
     *
     * Description:
     * Handles all CRUD operations for BatchRegister module.
     * Follows RESTful API standards with Clean Architecture.
     */
    [ApiController]
    [Route("api/InventoryManagement/BatchRegister")]
    public class BatchRegisterController : ControllerBase
    {
        private readonly IBatchRegisterService _service;

        /**
         * Constructor
         *
         * @param service Injected service for business logic
         */
        public BatchRegisterController(IBatchRegisterService service)
        {
            _service = service;
        }

        /**
         * Get all records
         *
         * @return List of BatchRegister objects
         */
        [HttpGet("all")]
        public async Task<ActionResult<List<BatchRegisterResponse>>> GetAll()
        {
            return await _service.All();
        }

        /**
         * Get paginated list
         *
         * @return List of BatchRegister objects
         */
        [HttpGet("index")]
        public async Task<ActionResult<List<BatchRegisterResponse>>> Index()
        {
            return await _service.Index();
        }

        /**
         * Get single record by id
         *
         * @param id Record identifier
         * @return Single BatchRegister object
         */
        [HttpGet("view/{id}")]
        public async Task<ActionResult<BatchRegisterResponse>> View(long id)
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
        public async Task<ActionResult<BatchRegisterResponse>> Create([FromBody] BatchRegisterRequest request)
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
        public async Task<ActionResult<BatchRegisterResponse>> Update(long id, [FromBody] BatchRegisterRequest request)
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
