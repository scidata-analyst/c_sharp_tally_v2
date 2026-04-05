using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Dashboard
{
    [Route("dashboard")]
    public class DashboardController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Dashboard/Dashboard.cshtml");
        }
    }
}
