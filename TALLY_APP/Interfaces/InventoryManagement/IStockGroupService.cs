using System.Collections.Generic;
using System.Threading.Tasks;
using InventoryManagement.DTOs.Request;
using InventoryManagement.DTOs.Response;

namespace TALLY_APP.Interfaces.InventoryManagement
{
    /**
     * =====================================================
     * Interface: IStockGroupService
     * =====================================================
     *
     * Purpose:
     * Defines contract for StockGroup business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IStockGroupService
    {
        /**
         * Get all records
         */
        Task<List<StockGroupResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<StockGroupResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<StockGroupResponse> View(long id);

        /**
         * Create new record
         */
        Task<StockGroupResponse> Create(StockGroupRequest request);

        /**
         * Update existing record
         */
        Task<StockGroupResponse> Update(long id, StockGroupRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
