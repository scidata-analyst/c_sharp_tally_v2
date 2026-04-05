using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Reporting
{
    [Route("reporting/stock-reports")]
    public class StockReportsController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Reporting/StockReports.cshtml");
        }
    }
}
