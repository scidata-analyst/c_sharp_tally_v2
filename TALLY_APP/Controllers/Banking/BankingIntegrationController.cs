using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Banking
{
    [Route("banking/banking-integration")]
    public class BankingIntegrationController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Banking/BankingIntegration.cshtml");
        }
    }
}
