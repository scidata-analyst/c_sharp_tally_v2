using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.PayrollManagement;
using TALLY_APP.DTOs.Response.PayrollManagement;

namespace TALLY_APP.Interfaces.PayrollManagement
{
    public interface IPayrollRunService
    {
        Task<List<PayrollRunResponse>> All();
        Task<PaginatedPayrollRunResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<PayrollRunResponse> View(long id);
        Task<PayrollRunResponse> Create(PayrollRunRequest request);
        Task<PayrollRunResponse> Update(long id, PayrollRunRequest request);
        Task<bool> Delete(long id);
    }
}
