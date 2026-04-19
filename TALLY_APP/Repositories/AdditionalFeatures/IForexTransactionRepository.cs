using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Repositories.AdditionalFeatures
{
    /**
     * @interface IForexTransactionRepository
     * @description Defines database contract for ForexTransaction entity operations.
     */
    public interface IForexTransactionRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all ForexTransaction records from database.
         * @returns {Task<List<ForexTransaction>>}
         */
        Task<List<ForexTransaction>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<ForexTransaction>}
         */
        Task<ForexTransaction> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {ForexTransaction} entity - Entity model
         */
        Task AddAsync(ForexTransaction entity);

        /**
         * @method UpdateAsync
         * @param {ForexTransaction} entity - Updated entity model
         */
        Task UpdateAsync(ForexTransaction entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
