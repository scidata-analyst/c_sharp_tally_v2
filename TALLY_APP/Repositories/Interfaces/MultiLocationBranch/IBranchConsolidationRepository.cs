using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.MultiLocationBranch
{
    /**
     * =====================================================
     * Repository Interface: IBranchConsolidationRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for BranchConsolidation entity.
     */
    public interface IBranchConsolidationRepository
    {
        Task<List<BranchConsolidation>> GetAllAsync();
        Task<BranchConsolidation> GetByIdAsync(long id);
        Task AddAsync(BranchConsolidation entity);
        Task UpdateAsync(BranchConsolidation entity);
        Task DeleteAsync(long id);
    }
}
