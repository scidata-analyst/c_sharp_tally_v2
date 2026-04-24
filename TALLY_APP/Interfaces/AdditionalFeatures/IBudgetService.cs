using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.AdditionalFeatures;
using TALLY_APP.DTOs.Response.AdditionalFeatures;

namespace TALLY_APP.Interfaces.AdditionalFeatures
{
    public interface IBudgetService
    {
        Task<PaginatedBudgetResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<BudgetResponse> Create(BudgetRequest request);
        Task<BudgetResponse> Update(long id, BudgetRequest request);
        Task<bool> Delete(long id);
    }
}
