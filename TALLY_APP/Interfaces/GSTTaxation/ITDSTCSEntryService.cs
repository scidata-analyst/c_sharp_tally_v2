using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.GSTTaxation;
using TALLY_APP.DTOs.Response.GSTTaxation;

namespace TALLY_APP.Interfaces.GstTaxation
{
    public interface ITDSTCSEntryService
    {
        Task<List<TDSTCSEntryResponse>> All();
        Task<PaginatedTDSTCSEntryResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<TDSTCSEntryResponse> View(long id);
        Task<TDSTCSEntryResponse> Create(TDSTCSEntryRequest request);
        Task<TDSTCSEntryResponse> Update(long id, TDSTCSEntryRequest request);
        Task<bool> Delete(long id);
    }
}
