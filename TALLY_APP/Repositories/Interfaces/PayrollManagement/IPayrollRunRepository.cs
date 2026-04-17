using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.PayrollManagement
{
    /**
     * =====================================================
     * Repository Interface: IPayrollRunRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for PayrollRun entity.
     */
    public interface IPayrollRunRepository
    {
        Task<List<PayrollRun>> GetAllAsync();
        Task<PayrollRun> GetByIdAsync(long id);
        Task AddAsync(PayrollRun entity);
        Task UpdateAsync(PayrollRun entity);
        Task DeleteAsync(long id);
    }
}
