using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.MultiLocationBranch
{
    /**
     * =====================================================
     * Repository Interface: IBranchPerformanceRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for BranchPerformance entity.
     */
    public interface IBranchPerformanceRepository
    {
        Task<List<BranchPerformance>> GetAllAsync();
        Task<BranchPerformance> GetByIdAsync(long id);
        Task AddAsync(BranchPerformance entity);
        Task UpdateAsync(BranchPerformance entity);
        Task DeleteAsync(long id);
    }
}
