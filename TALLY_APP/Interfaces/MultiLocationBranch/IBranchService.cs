using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.MultiLocationBranch;
using TALLY_APP.DTOs.Response.MultiLocationBranch;

namespace TALLY_APP.Interfaces.MultiLocationBranch
{
    public interface IBranchService
    {
        Task<List<BranchResponse>> All();
        Task<PaginatedBranchResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<BranchResponse> View(long id);
        Task<BranchResponse> Create(BranchRequest request);
        Task<BranchResponse> Update(long id, BranchRequest request);
        Task<bool> Delete(long id);
    }
}
