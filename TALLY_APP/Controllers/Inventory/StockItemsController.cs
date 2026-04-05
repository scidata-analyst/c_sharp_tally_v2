using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Inventory
{
    [Route("inventory/stock-items")]
    public class StockItemsController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Inventory/StockItems.cshtml");
        }
    }
}
