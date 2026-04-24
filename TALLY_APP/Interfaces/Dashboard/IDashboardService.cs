using System.Threading.Tasks;
using TALLY_APP.DTOs.Response.Dashboard;

namespace TALLY_APP.Interfaces.Dashboard
{
    public interface IDashboardService
    {
        Task<DashboardSummaryResponse> GetSummary();
    }
}
