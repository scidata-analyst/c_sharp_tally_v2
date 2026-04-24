using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.PayrollManagement;
using TALLY_APP.DTOs.Response.PayrollManagement;

namespace TALLY_APP.Interfaces.PayrollManagement
{
    public interface IPayslipService
    {
        Task<List<PayslipResponse>> All();
        Task<PaginatedPayslipResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<PayslipResponse> View(long id);
        Task<PayslipResponse> Create(PayslipRequest request);
        Task<PayslipResponse> Update(long id, PayslipRequest request);
        Task<bool> Delete(long id);
    }
}
