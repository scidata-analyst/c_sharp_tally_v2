using System.Collections.Generic;
using System.Threading.Tasks;
using InventoryManagement.DTOs.Request;
using InventoryManagement.DTOs.Response;

namespace TALLY_APP.Interfaces.InventoryManagement
{
    /**
     * =====================================================
     * Interface: IStockMovementService
     * =====================================================
     *
     * Purpose:
     * Defines contract for StockMovement business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IStockMovementService
    {
        /**
         * Get all records
         */
        Task<List<StockMovementResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<StockMovementResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<StockMovementResponse> View(long id);

        /**
         * Create new record
         */
        Task<StockMovementResponse> Create(StockMovementRequest request);

        /**
         * Update existing record
         */
        Task<StockMovementResponse> Update(long id, StockMovementRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
