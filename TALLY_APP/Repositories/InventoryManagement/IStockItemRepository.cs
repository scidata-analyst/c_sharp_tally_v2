using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.Entities.InventoryManagement;

namespace TALLY_APP.Repositories.InventoryManagement
{
    /**
     * @interface IStockItemRepository
     * @description Defines database contract for StockItem entity operations.
     */
    public interface IStockItemRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all StockItem records from database.
         * @returns {Task<List<StockItem>>}
         */
        Task<List<StockItem>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<StockItem>}
         */
        Task<StockItem> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {StockItem} entity - Entity model
         */
        Task AddAsync(StockItem entity);

        /**
         * @method UpdateAsync
         * @param {StockItem} entity - Updated entity model
         */
        Task UpdateAsync(StockItem entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
