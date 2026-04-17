using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.PayrollManagement
{
    /**
     * =====================================================
     * Repository Interface: IEmployeeRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for Employee entity.
     */
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllAsync();
        Task<Employee> GetByIdAsync(long id);
        Task AddAsync(Employee entity);
        Task UpdateAsync(Employee entity);
        Task DeleteAsync(long id);
    }
}
