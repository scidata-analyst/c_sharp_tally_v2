using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.Dashboard;

namespace TALLY_APP.Controllers.Dashboard
{
     [Route("Dashboard")]
    [ApiController]
    public class DashboardController : Controller
    {
        private readonly IDashboardService _service;
        public DashboardController(IDashboardService service) => _service = service;

        [HttpGet("")] 

        [HttpGet("api/summary")]
        public async Task<IActionResult> GetSummary() => Ok(await _service.GetSummary());
    }
}









