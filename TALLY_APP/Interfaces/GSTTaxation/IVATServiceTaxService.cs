using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.GSTTaxation;
using TALLY_APP.DTOs.Response.GSTTaxation;

namespace TALLY_APP.Interfaces.GstTaxation
{
    public interface IVATServiceTaxService
    {
        Task<List<VATServiceTaxResponse>> All();
        Task<PaginatedVATServiceTaxResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<VATServiceTaxResponse> View(long id);
        Task<VATServiceTaxResponse> Create(VATServiceTaxRequest request);
        Task<VATServiceTaxResponse> Update(long id, VATServiceTaxRequest request);
        Task<bool> Delete(long id);
    }
}
