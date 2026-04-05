using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Accounting
{
    [Route("accounting/payable")]
    public class PayableController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Accounting/Payable.cshtml");
        }
    }
}
