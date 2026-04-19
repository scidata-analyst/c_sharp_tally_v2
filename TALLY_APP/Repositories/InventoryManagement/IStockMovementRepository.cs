using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.InventoryManagement;

namespace TALLY_APP.Repositories.InventoryManagement
{
    /**
     * @interface IStockMovementRepository
     * @description Defines database contract for StockMovement entity operations.
     */
    public interface IStockMovementRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all StockMovement records from database.
         * @returns {Task<List<StockMovement>>}
         */
        Task<List<StockMovement>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<StockMovement>}
         */
        Task<StockMovement> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {StockMovement} entity - Entity model
         */
        Task AddAsync(StockMovement entity);

        /**
         * @method UpdateAsync
         * @param {StockMovement} entity - Updated entity model
         */
        Task UpdateAsync(StockMovement entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
