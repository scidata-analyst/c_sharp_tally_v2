using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Reporting
{
    [Route("reporting/trial-balance")]
    public class TrialBalanceController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Reporting/TrialBalance.cshtml");
        }
    }
}
