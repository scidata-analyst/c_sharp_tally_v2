using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.InventoryManagement
{
    /**
     * =====================================================
     * Repository Interface: IStockGroupRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for StockGroup entity.
     */
    public interface IStockGroupRepository
    {
        Task<List<StockGroup>> GetAllAsync();
        Task<StockGroup> GetByIdAsync(long id);
        Task AddAsync(StockGroup entity);
        Task UpdateAsync(StockGroup entity);
        Task DeleteAsync(long id);
    }
}
