using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.Dashboard
{
    /**
     * =====================================================
     * Repository Interface: IDashboardWidgetRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for DashboardWidget entity.
     */
    public interface IDashboardWidgetRepository
    {
        Task<List<DashboardWidget>> GetAllAsync();
        Task<DashboardWidget> GetByIdAsync(long id);
        Task AddAsync(DashboardWidget entity);
        Task UpdateAsync(DashboardWidget entity);
        Task DeleteAsync(long id);
    }
}
