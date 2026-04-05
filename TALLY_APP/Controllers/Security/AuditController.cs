using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Security
{
    [Route("security/audit")]
    public class AuditController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Security/Audit.cshtml");
        }
    }
}
