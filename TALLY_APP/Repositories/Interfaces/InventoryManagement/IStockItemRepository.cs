using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.InventoryManagement
{
    /**
     * =====================================================
     * Repository Interface: IStockItemRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for StockItem entity.
     */
    public interface IStockItemRepository
    {
        Task<List<StockItem>> GetAllAsync();
        Task<StockItem> GetByIdAsync(long id);
        Task AddAsync(StockItem entity);
        Task UpdateAsync(StockItem entity);
        Task DeleteAsync(long id);
    }
}
