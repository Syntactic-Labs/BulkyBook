using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class PurchaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
