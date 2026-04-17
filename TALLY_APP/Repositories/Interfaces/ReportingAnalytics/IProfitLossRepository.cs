using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.ReportingAnalytics
{
    /**
     * =====================================================
     * Repository Interface: IProfitLossRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for ProfitLoss entity.
     */
    public interface IProfitLossRepository
    {
        Task<List<ProfitLoss>> GetAllAsync();
        Task<ProfitLoss> GetByIdAsync(long id);
        Task AddAsync(ProfitLoss entity);
        Task UpdateAsync(ProfitLoss entity);
        Task DeleteAsync(long id);
    }
}
