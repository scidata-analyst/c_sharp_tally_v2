using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.GSTTaxation;
using TALLY_APP.DTOs.Response.GSTTaxation;

namespace TALLY_APP.Interfaces.GstTaxation
{
    public interface IGSTEntryService
    {
        Task<List<GSTEntryResponse>> All();
        Task<PaginatedGSTEntryResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<GSTEntryResponse> View(long id);
        Task<GSTEntryResponse> Create(GSTEntryRequest request);
        Task<GSTEntryResponse> Update(long id, GSTEntryRequest request);
        Task<bool> Delete(long id);
    }
}
