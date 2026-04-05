using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Addons
{
    [Route("addons/multi-currency-tx")]
    public class MultiCurrencyTxController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Addons/MultiCurrencyTx.cshtml");
        }
    }
}
