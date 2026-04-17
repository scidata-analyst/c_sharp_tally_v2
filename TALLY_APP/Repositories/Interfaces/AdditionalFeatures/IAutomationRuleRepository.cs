using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.AdditionalFeatures
{
    /**
     * =====================================================
     * Repository Interface: IAutomationRuleRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for AutomationRule entity.
     */
    public interface IAutomationRuleRepository
    {
        Task<List<AutomationRule>> GetAllAsync();
        Task<AutomationRule> GetByIdAsync(long id);
        Task AddAsync(AutomationRule entity);
        Task UpdateAsync(AutomationRule entity);
        Task DeleteAsync(long id);
    }
}
