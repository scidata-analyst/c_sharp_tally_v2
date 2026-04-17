using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.GSTTaxation
{
    /**
     * =====================================================
     * Repository Interface: ITDSTCSEntryRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for TDSTCSEntry entity.
     */
    public interface ITDSTCSEntryRepository
    {
        Task<List<TDSTCSEntry>> GetAllAsync();
        Task<TDSTCSEntry> GetByIdAsync(long id);
        Task AddAsync(TDSTCSEntry entity);
        Task UpdateAsync(TDSTCSEntry entity);
        Task DeleteAsync(long id);
    }
}
