using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.BankingPayments
{
    /**
     * =====================================================
     * Repository Interface: IBankIntegrationRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for BankIntegration entity.
     */
    public interface IBankIntegrationRepository
    {
        Task<List<BankIntegration>> GetAllAsync();
        Task<BankIntegration> GetByIdAsync(long id);
        Task AddAsync(BankIntegration entity);
        Task UpdateAsync(BankIntegration entity);
        Task DeleteAsync(long id);
    }
}
