using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _db;
        public UserController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<User> objUserList = _db.Users;
            return View(objUserList);
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
