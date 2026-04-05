using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Taxation
{
    [Route("taxation/gst-calc")]
    public class GstCalcController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Taxation/GstCalc.cshtml");
        }
    }
}
