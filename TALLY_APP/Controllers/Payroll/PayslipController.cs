using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Payroll
{
    [Route("payroll/payslip")]
    public class PayslipController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Payroll/Payslip.cshtml");
        }
    }
}
