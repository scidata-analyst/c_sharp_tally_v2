using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.Entities.AccountingFinance;

namespace TALLY_APP.Repositories.AccountingFinance
{
    /**
     * @interface ICurrencyExchangeRepository
     * @description Defines database contract for CurrencyExchange entity operations.
     */
    public interface ICurrencyExchangeRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all CurrencyExchange records from database.
         * @returns {Task<List<CurrencyExchange>>}
         */
        Task<List<CurrencyExchange>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<CurrencyExchange>}
         */
        Task<CurrencyExchange> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {CurrencyExchange} entity - Entity model
         */
        Task AddAsync(CurrencyExchange entity);

        /**
         * @method UpdateAsync
         * @param {CurrencyExchange} entity - Updated entity model
         */
        Task UpdateAsync(CurrencyExchange entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
