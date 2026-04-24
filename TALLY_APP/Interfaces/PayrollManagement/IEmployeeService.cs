using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.PayrollManagement;
using TALLY_APP.DTOs.Response.PayrollManagement;

namespace TALLY_APP.Interfaces.PayrollManagement
{
    public interface IEmployeeService
    {
        Task<List<EmployeeResponse>> All();
        Task<PaginatedEmployeeResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<EmployeeResponse> View(long id);
        Task<EmployeeResponse> Create(EmployeeRequest request);
        Task<EmployeeResponse> Update(long id, EmployeeRequest request);
        Task<bool> Delete(long id);
    }
}
