using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.Entities.PayrollManagement;

namespace TALLY_APP.Repositories.PayrollManagement
{
    /**
     * @interface IStatutoryDeductionRepository
     * @description Defines database contract for StatutoryDeduction entity operations.
     */
    public interface IStatutoryDeductionRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all StatutoryDeduction records from database.
         * @returns {Task<List<StatutoryDeduction>>}
         */
        Task<List<StatutoryDeduction>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<StatutoryDeduction>}
         */
        Task<StatutoryDeduction> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {StatutoryDeduction} entity - Entity model
         */
        Task AddAsync(StatutoryDeduction entity);

        /**
         * @method UpdateAsync
         * @param {StatutoryDeduction} entity - Updated entity model
         */
        Task UpdateAsync(StatutoryDeduction entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
