using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.AdditionalFeatures
{
    /**
     * =====================================================
     * Repository Interface: IBudgetRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for Budget entity.
     */
    public interface IBudgetRepository
    {
        Task<List<Budget>> GetAllAsync();
        Task<Budget> GetByIdAsync(long id);
        Task AddAsync(Budget entity);
        Task UpdateAsync(Budget entity);
        Task DeleteAsync(long id);
    }
}
