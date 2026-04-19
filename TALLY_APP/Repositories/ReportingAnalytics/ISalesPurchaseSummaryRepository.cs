using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.ReportingAnalytics;

namespace TALLY_APP.Repositories.ReportingAnalytics
{
    /**
     * @interface ISalesPurchaseSummaryRepository
     * @description Defines database contract for SalesPurchaseSummary entity operations.
     */
    public interface ISalesPurchaseSummaryRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all SalesPurchaseSummary records from database.
         * @returns {Task<List<SalesPurchaseSummary>>}
         */
        Task<List<SalesPurchaseSummary>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<SalesPurchaseSummary>}
         */
        Task<SalesPurchaseSummary> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {SalesPurchaseSummary} entity - Entity model
         */
        Task AddAsync(SalesPurchaseSummary entity);

        /**
         * @method UpdateAsync
         * @param {SalesPurchaseSummary} entity - Updated entity model
         */
        Task UpdateAsync(SalesPurchaseSummary entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
