using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Reporting
{
    [Route("reporting/sales-purchase")]
    public class SalesPurchaseController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Reporting/SalesPurchase.cshtml");
        }
    }
}
