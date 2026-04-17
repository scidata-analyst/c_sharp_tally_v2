using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.Entities.ReportingAnalytics;

namespace TALLY_APP.Repositories.ReportingAnalytics
{
    /**
     * @interface ITrialBalanceRepository
     * @description Defines database contract for TrialBalance entity operations.
     */
    public interface ITrialBalanceRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all TrialBalance records from database.
         * @returns {Task<List<TrialBalance>>}
         */
        Task<List<TrialBalance>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<TrialBalance>}
         */
        Task<TrialBalance> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {TrialBalance} entity - Entity model
         */
        Task AddAsync(TrialBalance entity);

        /**
         * @method UpdateAsync
         * @param {TrialBalance} entity - Updated entity model
         */
        Task UpdateAsync(TrialBalance entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
