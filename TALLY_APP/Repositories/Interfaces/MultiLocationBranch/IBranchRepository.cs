using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.MultiLocationBranch
{
    /**
     * =====================================================
     * Repository Interface: IBranchRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for Branch entity.
     */
    public interface IBranchRepository
    {
        Task<List<Branch>> GetAllAsync();
        Task<Branch> GetByIdAsync(long id);
        Task AddAsync(Branch entity);
        Task UpdateAsync(Branch entity);
        Task DeleteAsync(long id);
    }
}
