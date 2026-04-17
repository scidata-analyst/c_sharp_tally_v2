using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.AccountingFinance
{
    /**
     * =====================================================
     * Repository Interface: IBankReconciliationRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for BankReconciliation entity.
     */
    public interface IBankReconciliationRepository
    {
        Task<List<BankReconciliation>> GetAllAsync();
        Task<BankReconciliation> GetByIdAsync(long id);
        Task AddAsync(BankReconciliation entity);
        Task UpdateAsync(BankReconciliation entity);
        Task DeleteAsync(long id);
    }
}
