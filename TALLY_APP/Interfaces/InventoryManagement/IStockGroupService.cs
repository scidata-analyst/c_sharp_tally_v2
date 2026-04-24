using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.InventoryManagement;
using TALLY_APP.DTOs.Response.InventoryManagement;

namespace TALLY_APP.Interfaces.InventoryManagement
{
    public interface IStockGroupService
    {
        Task<List<StockGroupResponse>> All();
        Task<PaginatedStockGroupResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<StockGroupResponse> View(long id);
        Task<StockGroupResponse> Create(StockGroupRequest request);
        Task<StockGroupResponse> Update(long id, StockGroupRequest request);
        Task<bool> Delete(long id);
    }
}
