using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.ReportingAnalytics
{
    /**
     * =====================================================
     * Repository Interface: ITrialBalanceRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for TrialBalance entity.
     */
    public interface ITrialBalanceRepository
    {
        Task<List<TrialBalance>> GetAllAsync();
        Task<TrialBalance> GetByIdAsync(long id);
        Task AddAsync(TrialBalance entity);
        Task UpdateAsync(TrialBalance entity);
        Task DeleteAsync(long id);
    }
}
