using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.PayrollManagement
{
    /**
     * =====================================================
     * Repository Interface: IStatutoryDeductionRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for StatutoryDeduction entity.
     */
    public interface IStatutoryDeductionRepository
    {
        Task<List<StatutoryDeduction>> GetAllAsync();
        Task<StatutoryDeduction> GetByIdAsync(long id);
        Task AddAsync(StatutoryDeduction entity);
        Task UpdateAsync(StatutoryDeduction entity);
        Task DeleteAsync(long id);
    }
}
