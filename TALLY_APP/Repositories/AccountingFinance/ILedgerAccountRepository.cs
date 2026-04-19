using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.AccountingFinance;

namespace TALLY_APP.Repositories.AccountingFinance
{
    /**
     * @interface ILedgerAccountRepository
     * @description Defines database contract for LedgerAccount entity operations.
     */
    public interface ILedgerAccountRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all LedgerAccount records from database.
         * @returns {Task<List<LedgerAccount>>}
         */
        Task<List<LedgerAccount>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<LedgerAccount>}
         */
        Task<LedgerAccount> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {LedgerAccount} entity - Entity model
         */
        Task AddAsync(LedgerAccount entity);

        /**
         * @method UpdateAsync
         * @param {LedgerAccount} entity - Updated entity model
         */
        Task UpdateAsync(LedgerAccount entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
