using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Addons
{
    [Route("addons/custom-reports")]
    public class CustomReportsController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Addons/CustomReports.cshtml");
        }
    }
}
