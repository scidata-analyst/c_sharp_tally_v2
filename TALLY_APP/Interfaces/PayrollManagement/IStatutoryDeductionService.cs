using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.PayrollManagement;
using TALLY_APP.DTOs.Response.PayrollManagement;

namespace TALLY_APP.Interfaces.PayrollManagement
{
    public interface IStatutoryDeductionService
    {
        Task<List<StatutoryDeductionResponse>> All();
        Task<PaginatedStatutoryDeductionResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<StatutoryDeductionResponse> View(long id);
        Task<StatutoryDeductionResponse> Create(StatutoryDeductionRequest request);
        Task<StatutoryDeductionResponse> Update(long id, StatutoryDeductionRequest request);
        Task<bool> Delete(long id);
    }
}
