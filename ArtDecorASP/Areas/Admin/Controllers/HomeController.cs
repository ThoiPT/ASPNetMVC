using Microsoft.AspNetCore.Mvc;

namespace ArtDecorASP.Areas.Admin.Controllers
{
    // Định danh cho Controller
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
