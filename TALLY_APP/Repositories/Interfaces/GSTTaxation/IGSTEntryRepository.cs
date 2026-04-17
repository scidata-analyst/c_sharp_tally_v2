using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.GSTTaxation
{
    /**
     * =====================================================
     * Repository Interface: IGSTEntryRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for GSTEntry entity.
     */
    public interface IGSTEntryRepository
    {
        Task<List<GSTEntry>> GetAllAsync();
        Task<GSTEntry> GetByIdAsync(long id);
        Task AddAsync(GSTEntry entity);
        Task UpdateAsync(GSTEntry entity);
        Task DeleteAsync(long id);
    }
}
