using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Payroll
{
    [Route("payroll/payroll-calc")]
    public class PayrollCalcController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Payroll/PayrollCalc.cshtml");
        }
    }
}
