using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.ReportingAnalytics;

namespace TALLY_APP.Repositories.ReportingAnalytics
{
    /**
     * @interface IBalanceSheetRepository
     * @description Defines database contract for BalanceSheet entity operations.
     */
    public interface IBalanceSheetRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all BalanceSheet records from database.
         * @returns {Task<List<BalanceSheet>>}
         */
        Task<List<BalanceSheet>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<BalanceSheet>}
         */
        Task<BalanceSheet> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {BalanceSheet} entity - Entity model
         */
        Task AddAsync(BalanceSheet entity);

        /**
         * @method UpdateAsync
         * @param {BalanceSheet} entity - Updated entity model
         */
        Task UpdateAsync(BalanceSheet entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
