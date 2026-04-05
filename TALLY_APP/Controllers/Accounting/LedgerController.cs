using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Accounting
{
    [Route("accounting/ledger")]
    public class LedgerController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Accounting/Ledger.cshtml");
        }
    }
}
