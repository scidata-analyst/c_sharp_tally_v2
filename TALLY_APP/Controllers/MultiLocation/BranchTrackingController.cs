using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.MultiLocation
{
    [Route("multilocation/branch-tracking")]
    public class BranchTrackingController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/MultiLocation/BranchTracking.cshtml");
        }
    }
}
