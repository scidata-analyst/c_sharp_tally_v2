using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.InventoryManagement;
using TALLY_APP.DTOs.Response.InventoryManagement;

namespace TALLY_APP.Interfaces.InventoryManagement
{
    public interface IStockItemService
    {
        Task<List<StockItemResponse>> All();
        Task<PaginatedStockItemResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<StockItemResponse> View(long id);
        Task<StockItemResponse> Create(StockItemRequest request);
        Task<StockItemResponse> Update(long id, StockItemRequest request);
        Task<bool> Delete(long id);
    }
}
