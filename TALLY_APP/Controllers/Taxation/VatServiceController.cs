using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Taxation
{
    [Route("taxation/vat-service")]
    public class VatServiceController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Taxation/VatService.cshtml");
        }
    }
}
