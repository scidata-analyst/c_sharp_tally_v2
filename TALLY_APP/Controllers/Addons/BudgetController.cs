using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Addons
{
    [Route("addons/budget")]
    public class BudgetController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Addons/Budget.cshtml");
        }
    }
}
