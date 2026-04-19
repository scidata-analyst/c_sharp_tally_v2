using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.InventoryManagement;

namespace TALLY_APP.Repositories.InventoryManagement
{
    /**
     * @interface IStockGroupRepository
     * @description Defines database contract for StockGroup entity operations.
     */
    public interface IStockGroupRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all StockGroup records from database.
         * @returns {Task<List<StockGroup>>}
         */
        Task<List<StockGroup>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<StockGroup>}
         */
        Task<StockGroup> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {StockGroup} entity - Entity model
         */
        Task AddAsync(StockGroup entity);

        /**
         * @method UpdateAsync
         * @param {StockGroup} entity - Updated entity model
         */
        Task UpdateAsync(StockGroup entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
