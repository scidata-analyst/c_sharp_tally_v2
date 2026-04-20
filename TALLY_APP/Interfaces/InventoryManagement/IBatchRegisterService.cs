using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.InventoryManagement;
using TALLY_APP.DTOs.Response.InventoryManagement;

namespace TALLY_APP.Interfaces.InventoryManagement
{
    /**
     * =====================================================
     * Interface: IBatchRegisterService
     * =====================================================
     *
     * Purpose:
     * Defines contract for BatchRegister business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IBatchRegisterService
    {
        /**
         * Get all records
         */
        Task<List<BatchRegisterResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<BatchRegisterResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<BatchRegisterResponse> View(long id);

        /**
         * Create new record
         */
        Task<BatchRegisterResponse> Create(BatchRegisterRequest request);

        /**
         * Update existing record
         */
        Task<BatchRegisterResponse> Update(long id, BatchRegisterRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
