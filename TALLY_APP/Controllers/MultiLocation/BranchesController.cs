using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.MultiLocation
{
    [Route("multilocation/branches")]
    public class BranchesController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/MultiLocation/Branches.cshtml");
        }
    }
}
