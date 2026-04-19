using System.Collections.Generic;
using System.Threading.Tasks;
using InventoryManagement.DTOs.Request;
using InventoryManagement.DTOs.Response;

namespace TALLY_APP.Interfaces.InventoryManagement
{
    /**
     * =====================================================
     * Interface: IGodownService
     * =====================================================
     *
     * Purpose:
     * Defines contract for Godown business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IGodownService
    {
        /**
         * Get all records
         */
        Task<List<GodownResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<GodownResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<GodownResponse> View(long id);

        /**
         * Create new record
         */
        Task<GodownResponse> Create(GodownRequest request);

        /**
         * Update existing record
         */
        Task<GodownResponse> Update(long id, GodownRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
