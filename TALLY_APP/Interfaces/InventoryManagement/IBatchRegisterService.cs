using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.InventoryManagement;
using TALLY_APP.DTOs.Response.InventoryManagement;

namespace TALLY_APP.Interfaces.InventoryManagement
{
    public interface IBatchRegisterService
    {
        Task<List<BatchRegisterResponse>> All();
        Task<PaginatedBatchRegisterResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<BatchRegisterResponse> View(long id);
        Task<BatchRegisterResponse> Create(BatchRegisterRequest request);
        Task<BatchRegisterResponse> Update(long id, BatchRegisterRequest request);
        Task<bool> Delete(long id);
    }
}
