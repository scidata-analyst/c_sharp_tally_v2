using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.ReportingAnalytics
{
    /**
     * =====================================================
     * Repository Interface: IStockReportRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for StockReport entity.
     */
    public interface IStockReportRepository
    {
        Task<List<StockReport>> GetAllAsync();
        Task<StockReport> GetByIdAsync(long id);
        Task AddAsync(StockReport entity);
        Task UpdateAsync(StockReport entity);
        Task DeleteAsync(long id);
    }
}
