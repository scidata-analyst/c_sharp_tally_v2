using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.InventoryManagement
{
    /**
     * =====================================================
     * Repository Interface: IGodownRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for Godown entity.
     */
    public interface IGodownRepository
    {
        Task<List<Godown>> GetAllAsync();
        Task<Godown> GetByIdAsync(long id);
        Task AddAsync(Godown entity);
        Task UpdateAsync(Godown entity);
        Task DeleteAsync(long id);
    }
}
