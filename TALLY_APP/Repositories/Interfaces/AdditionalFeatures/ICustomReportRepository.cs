using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.AdditionalFeatures
{
    /**
     * =====================================================
     * Repository Interface: ICustomReportRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for CustomReport entity.
     */
    public interface ICustomReportRepository
    {
        Task<List<CustomReport>> GetAllAsync();
        Task<CustomReport> GetByIdAsync(long id);
        Task AddAsync(CustomReport entity);
        Task UpdateAsync(CustomReport entity);
        Task DeleteAsync(long id);
    }
}
