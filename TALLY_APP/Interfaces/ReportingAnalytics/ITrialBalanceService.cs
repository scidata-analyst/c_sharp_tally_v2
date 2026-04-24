using System.Threading.Tasks;
using TALLY_APP.DTOs.Response.ReportingAnalytics;

namespace TALLY_APP.Interfaces.ReportingAnalytics
{
    public interface ITrialBalanceService
    {
        Task<PaginatedTrialBalanceResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
    }
}
