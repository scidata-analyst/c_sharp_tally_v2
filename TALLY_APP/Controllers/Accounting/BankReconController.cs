using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Accounting
{
    [Route("accounting/bank-recon")]
    public class BankReconController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Accounting/BankRecon.cshtml");
        }
    }
}
