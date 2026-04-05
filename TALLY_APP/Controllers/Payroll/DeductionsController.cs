using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Payroll
{
    [Route("payroll/deductions")]
    public class DeductionsController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Payroll/Deductions.cshtml");
        }
    }
}
