using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Inventory
{
    [Route("inventory/stock-groups")]
    public class StockGroupsController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Inventory/StockGroups.cshtml");
        }
    }
}
