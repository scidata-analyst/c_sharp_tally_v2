using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.MultiLocationBranch;
using TALLY_APP.DTOs.Response.MultiLocationBranch;

namespace TALLY_APP.Interfaces.MultiLocationBranch
{
    public interface IBranchConsolidationService
    {
        Task<List<BranchConsolidationResponse>> All();
        Task<PaginatedBranchConsolidationResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<BranchConsolidationResponse> View(long id);
        Task<BranchConsolidationResponse> Create(BranchConsolidationRequest request);
        Task<BranchConsolidationResponse> Update(long id, BranchConsolidationRequest request);
        Task<bool> Delete(long id);
    }
}
