using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Repositories.AdditionalFeatures
{
    /**
     * @interface IBudgetRepository
     * @description Defines database contract for Budget entity operations.
     */
    public interface IBudgetRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all Budget records from database.
         * @returns {Task<List<Budget>>}
         */
        Task<List<Budget>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<Budget>}
         */
        Task<Budget> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {Budget} entity - Entity model
         */
        Task AddAsync(Budget entity);

        /**
         * @method UpdateAsync
         * @param {Budget} entity - Updated entity model
         */
        Task UpdateAsync(Budget entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
