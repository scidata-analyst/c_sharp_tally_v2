using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.AdditionalFeatures;
using TALLY_APP.DTOs.Response.AdditionalFeatures;

namespace TALLY_APP.Interfaces.AdditionalFeatures
{
    public interface ICustomReportService
    {
        Task<PaginatedCustomReportResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<CustomReportResponse> Create(CustomReportRequest request);
        Task<CustomReportResponse> Update(long id, CustomReportRequest request);
        Task<bool> Delete(long id);
    }
}
