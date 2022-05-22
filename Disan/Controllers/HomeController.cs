using Disan.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Disan.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.blogs = _db.Blogs.ToList();
            return View(_db.Products.ToList());
        }
    }
}
