using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Banking
{
    [Route("banking/reminders")]
    public class RemindersController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Banking/Reminders.cshtml");
        }
    }
}
