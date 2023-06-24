using Microsoft.AspNetCore.Mvc;

namespace GKrewBodegaWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
