using Microsoft.AspNetCore.Mvc;

namespace TALLY_APP.Controllers.Inventory
{
    [Route("inventory/stock-movement")]
    public class StockMovementController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Inventory/StockMovement.cshtml");
        }
    }
}
