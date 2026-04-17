using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.AccountingFinance
{
    /**
     * =====================================================
     * Repository Interface: IBankAccountRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for BankAccount entity.
     */
    public interface IBankAccountRepository
    {
        Task<List<BankAccount>> GetAllAsync();
        Task<BankAccount> GetByIdAsync(long id);
        Task AddAsync(BankAccount entity);
        Task UpdateAsync(BankAccount entity);
        Task DeleteAsync(long id);
    }
}
