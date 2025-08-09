using Microsoft.AspNetCore.Mvc;

namespace Warehouse.Service.Inventory.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
