using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.ReportingAnalytics;

namespace TALLY_APP.Repositories.ReportingAnalytics
{
    /**
     * @interface IProfitLossRepository
     * @description Defines database contract for ProfitLoss entity operations.
     */
    public interface IProfitLossRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all ProfitLoss records from database.
         * @returns {Task<List<ProfitLoss>>}
         */
        Task<List<ProfitLoss>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<ProfitLoss>}
         */
        Task<ProfitLoss> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {ProfitLoss} entity - Entity model
         */
        Task AddAsync(ProfitLoss entity);

        /**
         * @method UpdateAsync
         * @param {ProfitLoss} entity - Updated entity model
         */
        Task UpdateAsync(ProfitLoss entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
