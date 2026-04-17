using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.InventoryManagement
{
    /**
     * =====================================================
     * Repository Interface: IStockMovementRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for StockMovement entity.
     */
    public interface IStockMovementRepository
    {
        Task<List<StockMovement>> GetAllAsync();
        Task<StockMovement> GetByIdAsync(long id);
        Task AddAsync(StockMovement entity);
        Task UpdateAsync(StockMovement entity);
        Task DeleteAsync(long id);
    }
}
