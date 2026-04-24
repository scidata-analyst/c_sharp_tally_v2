using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.InventoryManagement;
using TALLY_APP.DTOs.Response.InventoryManagement;

namespace TALLY_APP.Interfaces.InventoryManagement
{
    public interface IStockMovementService
    {
        Task<List<StockMovementResponse>> All();
        Task<PaginatedStockMovementResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<StockMovementResponse> View(long id);
        Task<StockMovementResponse> Create(StockMovementRequest request);
        Task<StockMovementResponse> Update(long id, StockMovementRequest request);
        Task<bool> Delete(long id);
    }
}
