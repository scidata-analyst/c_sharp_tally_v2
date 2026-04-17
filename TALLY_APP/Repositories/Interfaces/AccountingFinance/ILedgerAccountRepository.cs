using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.AccountingFinance
{
    /**
     * =====================================================
     * Repository Interface: ILedgerAccountRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for LedgerAccount entity.
     */
    public interface ILedgerAccountRepository
    {
        Task<List<LedgerAccount>> GetAllAsync();
        Task<LedgerAccount> GetByIdAsync(long id);
        Task AddAsync(LedgerAccount entity);
        Task UpdateAsync(LedgerAccount entity);
        Task DeleteAsync(long id);
    }
}
