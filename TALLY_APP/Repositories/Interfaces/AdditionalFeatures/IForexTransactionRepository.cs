using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.AdditionalFeatures
{
    /**
     * =====================================================
     * Repository Interface: IForexTransactionRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for ForexTransaction entity.
     */
    public interface IForexTransactionRepository
    {
        Task<List<ForexTransaction>> GetAllAsync();
        Task<ForexTransaction> GetByIdAsync(long id);
        Task AddAsync(ForexTransaction entity);
        Task UpdateAsync(ForexTransaction entity);
        Task DeleteAsync(long id);
    }
}
