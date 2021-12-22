using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class VendorController : Controller
    {
        private readonly AppDbContext _db;
        public VendorController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Vendor> objVendorList = _db.Vendors;
            return View(objVendorList);
        }
    }
}
