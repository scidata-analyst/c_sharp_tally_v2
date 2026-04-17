using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.GSTTaxation
{
    /**
     * =====================================================
     * Repository Interface: IGSTReturnRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for GSTReturn entity.
     */
    public interface IGSTReturnRepository
    {
        Task<List<GSTReturn>> GetAllAsync();
        Task<GSTReturn> GetByIdAsync(long id);
        Task AddAsync(GSTReturn entity);
        Task UpdateAsync(GSTReturn entity);
        Task DeleteAsync(long id);
    }
}
