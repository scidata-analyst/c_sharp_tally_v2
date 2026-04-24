using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.GSTTaxation;
using TALLY_APP.DTOs.Response.GSTTaxation;

namespace TALLY_APP.Interfaces.GstTaxation
{
    public interface IGSTReturnService
    {
        Task<List<GSTReturnResponse>> All();
        Task<PaginatedGSTReturnResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<GSTReturnResponse> View(long id);
        Task<GSTReturnResponse> Create(GSTReturnRequest request);
        Task<GSTReturnResponse> Update(long id, GSTReturnRequest request);
        Task<bool> Delete(long id);
    }
}
