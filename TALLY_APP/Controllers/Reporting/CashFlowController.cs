using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Reporting
{
    [Route("reporting/cash-flow")]
    public class CashFlowController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Reporting/CashFlow.cshtml");
        }
    }
}
