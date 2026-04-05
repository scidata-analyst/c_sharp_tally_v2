using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.MultiLocation
{
    [Route("multilocation/consolidation")]
    public class ConsolidationController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/MultiLocation/Consolidation.cshtml");
        }
    }
}
