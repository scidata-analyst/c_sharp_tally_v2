using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Taxation
{
    [Route("taxation/tax-reports")]
    public class TaxReportsController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Taxation/TaxReports.cshtml");
        }
    }
}
