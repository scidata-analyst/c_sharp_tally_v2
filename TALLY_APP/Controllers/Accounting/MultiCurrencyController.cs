using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Accounting
{
    [Route("accounting/multi-currency")]
    public class MultiCurrencyController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Accounting/MultiCurrency.cshtml");
        }
    }
}
