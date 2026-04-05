using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Taxation
{
    [Route("taxation/tds-tcs")]
    public class TdsTcsController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Taxation/TdsTcs.cshtml");
        }
    }
}
