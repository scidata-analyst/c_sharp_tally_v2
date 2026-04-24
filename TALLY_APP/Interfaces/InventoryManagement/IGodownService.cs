using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.InventoryManagement;
using TALLY_APP.DTOs.Response.InventoryManagement;

namespace TALLY_APP.Interfaces.InventoryManagement
{
    public interface IGodownService
    {
        Task<List<GodownResponse>> All();
        Task<PaginatedGodownResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<GodownResponse> View(long id);
        Task<GodownResponse> Create(GodownRequest request);
        Task<GodownResponse> Update(long id, GodownRequest request);
        Task<bool> Delete(long id);
    }
}
