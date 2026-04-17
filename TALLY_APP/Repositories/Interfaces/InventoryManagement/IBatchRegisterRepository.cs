using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.InventoryManagement
{
    /**
     * =====================================================
     * Repository Interface: IBatchRegisterRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for BatchRegister entity.
     */
    public interface IBatchRegisterRepository
    {
        Task<List<BatchRegister>> GetAllAsync();
        Task<BatchRegister> GetByIdAsync(long id);
        Task AddAsync(BatchRegister entity);
        Task UpdateAsync(BatchRegister entity);
        Task DeleteAsync(long id);
    }
}
