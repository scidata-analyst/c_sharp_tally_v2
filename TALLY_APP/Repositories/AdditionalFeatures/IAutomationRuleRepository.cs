using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.Entities.AdditionalFeatures;

namespace TALLY_APP.Repositories.AdditionalFeatures
{
    /**
     * @interface IAutomationRuleRepository
     * @description Defines database contract for AutomationRule entity operations.
     */
    public interface IAutomationRuleRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all AutomationRule records from database.
         * @returns {Task<List<AutomationRule>>}
         */
        Task<List<AutomationRule>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<AutomationRule>}
         */
        Task<AutomationRule> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {AutomationRule} entity - Entity model
         */
        Task AddAsync(AutomationRule entity);

        /**
         * @method UpdateAsync
         * @param {AutomationRule} entity - Updated entity model
         */
        Task UpdateAsync(AutomationRule entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
