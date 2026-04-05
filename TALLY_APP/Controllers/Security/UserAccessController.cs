using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Security
{
    [Route("security/user-access")]
    public class UserAccessController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Security/UserAccess.cshtml");
        }
    }
}
