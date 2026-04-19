using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.BankingPayments;

namespace TALLY_APP.Repositories.BankingPayments
{
    /**
     * @interface IBankIntegrationRepository
     * @description Defines database contract for BankIntegration entity operations.
     */
    public interface IBankIntegrationRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all BankIntegration records from database.
         * @returns {Task<List<BankIntegration>>}
         */
        Task<List<BankIntegration>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<BankIntegration>}
         */
        Task<BankIntegration> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {BankIntegration} entity - Entity model
         */
        Task AddAsync(BankIntegration entity);

        /**
         * @method UpdateAsync
         * @param {BankIntegration} entity - Updated entity model
         */
        Task UpdateAsync(BankIntegration entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
