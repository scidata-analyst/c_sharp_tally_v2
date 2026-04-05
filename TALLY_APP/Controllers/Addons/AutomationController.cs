using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Addons
{
    [Route("addons/automation")]
    public class AutomationController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Addons/Automation.cshtml");
        }
    }
}
