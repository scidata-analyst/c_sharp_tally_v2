using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.BankingPayments;
using TALLY_APP.DTOs.Response.BankingPayments;

namespace TALLY_APP.Interfaces.BankingPayments
{
    public interface IBankIntegrationService
    {
        Task<List<BankIntegrationResponse>> All();
        Task<PaginatedBankIntegrationResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<BankIntegrationResponse> View(long id);
        Task<BankIntegrationResponse> Create(BankIntegrationRequest request);
        Task<BankIntegrationResponse> Update(long id, BankIntegrationRequest request);
        Task<bool> Delete(long id);
    }
}
