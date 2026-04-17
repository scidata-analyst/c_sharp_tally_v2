using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.ReportingAnalytics
{
    /**
     * =====================================================
     * Repository Interface: IBalanceSheetRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for BalanceSheet entity.
     */
    public interface IBalanceSheetRepository
    {
        Task<List<BalanceSheet>> GetAllAsync();
        Task<BalanceSheet> GetByIdAsync(long id);
        Task AddAsync(BalanceSheet entity);
        Task UpdateAsync(BalanceSheet entity);
        Task DeleteAsync(long id);
    }
}
