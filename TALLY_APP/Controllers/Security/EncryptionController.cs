using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Security
{
    [Route("security/encryption")]
    public class EncryptionController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Security/Encryption.cshtml");
        }
    }
}
