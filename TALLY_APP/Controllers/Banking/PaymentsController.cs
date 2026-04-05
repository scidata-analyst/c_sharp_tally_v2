using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Banking
{
    [Route("banking/payments")]
    public class PaymentsController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Banking/Payments.cshtml");
        }
    }
}
