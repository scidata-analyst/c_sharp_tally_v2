using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Inventory
{
    [Route("inventory/godown")]
    public class GodownController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Inventory/Godown.cshtml");
        }
    }
}
