using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.PayrollManagement
{
    /**
     * =====================================================
     * Repository Interface: IPayslipRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for Payslip entity.
     */
    public interface IPayslipRepository
    {
        Task<List<Payslip>> GetAllAsync();
        Task<Payslip> GetByIdAsync(long id);
        Task AddAsync(Payslip entity);
        Task UpdateAsync(Payslip entity);
        Task DeleteAsync(long id);
    }
}
