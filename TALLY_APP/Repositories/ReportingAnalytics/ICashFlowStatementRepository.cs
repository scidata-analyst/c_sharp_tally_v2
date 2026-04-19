using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.ReportingAnalytics;

namespace TALLY_APP.Repositories.ReportingAnalytics
{
    /**
     * @interface ICashFlowStatementRepository
     * @description Defines database contract for CashFlowStatement entity operations.
     */
    public interface ICashFlowStatementRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all CashFlowStatement records from database.
         * @returns {Task<List<CashFlowStatement>>}
         */
        Task<List<CashFlowStatement>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<CashFlowStatement>}
         */
        Task<CashFlowStatement> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {CashFlowStatement} entity - Entity model
         */
        Task AddAsync(CashFlowStatement entity);

        /**
         * @method UpdateAsync
         * @param {CashFlowStatement} entity - Updated entity model
         */
        Task UpdateAsync(CashFlowStatement entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
