using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.AdditionalFeatures;
using TALLY_APP.DTOs.Response.AdditionalFeatures;

namespace TALLY_APP.Interfaces.AdditionalFeatures
{
    public interface IForexTransactionService
    {
        Task<PaginatedForexTransactionResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "desc");
        Task<ForexTransactionResponse> Create(ForexTransactionRequest request);
        Task<ForexTransactionResponse> Update(long id, ForexTransactionRequest request);
        Task<bool> Delete(long id);
    }
}
