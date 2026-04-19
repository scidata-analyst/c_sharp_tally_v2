using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.AccountingFinance;

namespace TALLY_APP.Repositories.AccountingFinance
{
    /**
     * @interface IBankAccountRepository
     * @description Defines database contract for BankAccount entity operations.
     */
    public interface IBankAccountRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all BankAccount records from database.
         * @returns {Task<List<BankAccount>>}
         */
        Task<List<BankAccount>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<BankAccount>}
         */
        Task<BankAccount> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {BankAccount} entity - Entity model
         */
        Task AddAsync(BankAccount entity);

        /**
         * @method UpdateAsync
         * @param {BankAccount} entity - Updated entity model
         */
        Task UpdateAsync(BankAccount entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
