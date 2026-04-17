using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.ReportingAnalytics
{
    /**
     * =====================================================
     * Repository Interface: ICashFlowStatementRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for CashFlowStatement entity.
     */
    public interface ICashFlowStatementRepository
    {
        Task<List<CashFlowStatement>> GetAllAsync();
        Task<CashFlowStatement> GetByIdAsync(long id);
        Task AddAsync(CashFlowStatement entity);
        Task UpdateAsync(CashFlowStatement entity);
        Task DeleteAsync(long id);
    }
}
