using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Payroll
{
    [Route("payroll/employees")]
    public class EmployeesController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Payroll/Employees.cshtml");
        }
    }
}
