using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Inventory
{
    [Route("inventory/batch-tracking")]
    public class BatchTrackingController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Inventory/BatchTracking.cshtml");
        }
    }
}
