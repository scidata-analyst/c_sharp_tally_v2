using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Accounting
{
    [Route("accounting/cash-bank")]
    public class CashBankController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Accounting/CashBank.cshtml");
        }
    }
}
