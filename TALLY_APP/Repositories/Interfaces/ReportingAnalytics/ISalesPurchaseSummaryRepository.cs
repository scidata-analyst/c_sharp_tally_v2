using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.ReportingAnalytics
{
    /**
     * =====================================================
     * Repository Interface: ISalesPurchaseSummaryRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for SalesPurchaseSummary entity.
     */
    public interface ISalesPurchaseSummaryRepository
    {
        Task<List<SalesPurchaseSummary>> GetAllAsync();
        Task<SalesPurchaseSummary> GetByIdAsync(long id);
        Task AddAsync(SalesPurchaseSummary entity);
        Task UpdateAsync(SalesPurchaseSummary entity);
        Task DeleteAsync(long id);
    }
}
