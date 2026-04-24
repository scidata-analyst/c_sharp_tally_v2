using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.MultiLocationBranch;
using TALLY_APP.DTOs.Response.MultiLocationBranch;

namespace TALLY_APP.Interfaces.MultiLocationBranch
{
    public interface IBranchPerformanceService
    {
        Task<List<BranchPerformanceResponse>> All();
        Task<PaginatedBranchPerformanceResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<BranchPerformanceResponse> View(long id);
        Task<BranchPerformanceResponse> Create(BranchPerformanceRequest request);
        Task<BranchPerformanceResponse> Update(long id, BranchPerformanceRequest request);
        Task<bool> Delete(long id);
    }
}
