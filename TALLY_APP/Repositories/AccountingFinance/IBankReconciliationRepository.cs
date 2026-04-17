using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.Entities.AccountingFinance;

namespace TALLY_APP.Repositories.AccountingFinance
{
    /**
     * @interface IBankReconciliationRepository
     * @description Defines database contract for BankReconciliation entity operations.
     */
    public interface IBankReconciliationRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all BankReconciliation records from database.
         * @returns {Task<List<BankReconciliation>>}
         */
        Task<List<BankReconciliation>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<BankReconciliation>}
         */
        Task<BankReconciliation> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {BankReconciliation} entity - Entity model
         */
        Task AddAsync(BankReconciliation entity);

        /**
         * @method UpdateAsync
         * @param {BankReconciliation} entity - Updated entity model
         */
        Task UpdateAsync(BankReconciliation entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
