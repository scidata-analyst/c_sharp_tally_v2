using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.Entities.ReportingAnalytics;

namespace TALLY_APP.Repositories.ReportingAnalytics
{
    /**
     * @interface IStockReportRepository
     * @description Defines database contract for StockReport entity operations.
     */
    public interface IStockReportRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all StockReport records from database.
         * @returns {Task<List<StockReport>>}
         */
        Task<List<StockReport>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<StockReport>}
         */
        Task<StockReport> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {StockReport} entity - Entity model
         */
        Task AddAsync(StockReport entity);

        /**
         * @method UpdateAsync
         * @param {StockReport} entity - Updated entity model
         */
        Task UpdateAsync(StockReport entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
