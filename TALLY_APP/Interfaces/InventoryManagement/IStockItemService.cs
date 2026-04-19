using System.Collections.Generic;
using System.Threading.Tasks;
using InventoryManagement.DTOs.Request;
using InventoryManagement.DTOs.Response;

namespace TALLY_APP.Interfaces.InventoryManagement
{
    /**
     * =====================================================
     * Interface: IStockItemService
     * =====================================================
     *
     * Purpose:
     * Defines contract for StockItem business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IStockItemService
    {
        /**
         * Get all records
         */
        Task<List<StockItemResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<StockItemResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<StockItemResponse> View(long id);

        /**
         * Create new record
         */
        Task<StockItemResponse> Create(StockItemRequest request);

        /**
         * Update existing record
         */
        Task<StockItemResponse> Update(long id, StockItemRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
